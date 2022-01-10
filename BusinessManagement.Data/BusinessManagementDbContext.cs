using BusinessManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.Data
{
    public class BusinessManagementDbContext : DbContext
    {
        public BusinessManagementDbContext(DbContextOptions<BusinessManagementDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Username = "admin", Password = "admin" });
            base.OnModelCreating(modelBuilder);
        }
    }
}
