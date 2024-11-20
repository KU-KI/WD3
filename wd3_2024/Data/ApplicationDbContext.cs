using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wd3_2024.Models;

namespace wd3_2024.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<wd3_2024.Models.Student> Student { get; set; } = default!;
        public DbSet<wd3_2024.Models.Teacher> Teacher { get; set; } = default!;
    }
}
