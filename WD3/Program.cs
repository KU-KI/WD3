using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WD3.Data;

var builder = WebApplication.CreateBuilder(args);

//Configuration for Docker MSSQL/MYSQL Databases
var server = builder.Configuration["DBServer"] ?? "localhost";
var port = builder.Configuration["DBPort"] ?? "3306";   //mssql 1433, mysql 3306
var user = builder.Configuration["DBUser"] ?? "wd333";  //mssql SA, mysql wd3
var password = builder.Configuration["DBPassword"] ?? "wd333";
var database = builder.Configuration["Database"] ?? "wd333";

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
var connectionString = $"server={server};user={user};password={password};database={database}";
builder.Services.AddDbContext<ApplicationDbContext>(options => options
            //Local MS SQL Database
            //.UseSqlServer(connectionString));
            //Docker MS SQL Database
            //.UseSqlServer($"Server={server},{port};Initial Catalog={database};User ID={user};Password={password}"));
            //Docker MySQL Database
            .UseMySql(connectionString, 
                      ServerVersion.AutoDetect(connectionString))
                      //new MariaDbServerVersion(new Version(10, 5, 8)))//, // use MariaDbServerVersion for MariaDB, MySqlServerVersion for MySQL
                      //mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend))
            // Everything from this point on is optional but helps with debugging.
            //.EnableSensitiveDataLogging()
            //.EnableDetailedErrors()
            );
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
