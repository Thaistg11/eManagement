using eManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eManagement.Data
{
    public class ApplicationDbContex:IdentityDbContext
    {
    public ApplicationDbContex(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<eManagementLeadEntity> eManagementLeadEntity { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Site> Site { get; set; }

        public DbSet<Department> Department { get; set; }

    }
}
