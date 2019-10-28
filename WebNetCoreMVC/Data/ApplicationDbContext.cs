using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebNetCoreMVC.Models;

namespace WebNetCoreMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebNetCoreMVC.Models.Student> Student { get; set; }
        public DbSet<WebNetCoreMVC.Models.Teacher> Teacher { get; set; }
    }
}
