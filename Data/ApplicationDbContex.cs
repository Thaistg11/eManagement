using eManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace eManagement.Data
{
    public class ApplicationDbContex:DbContext
    {
    public ApplicationDbContex(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<eManagementLeadEntity> eManagementLeadEntity { get; set; }
      
    }
}
