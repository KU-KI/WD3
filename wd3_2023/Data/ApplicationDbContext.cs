using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wd3_2023.Models;

namespace wd3_2023.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<wd3_2023.Models.Student> Student { get; set; } = default!;
        public DbSet<wd3_2023.Models.Teacher> Teacher { get; set; } = default!;
    }
}