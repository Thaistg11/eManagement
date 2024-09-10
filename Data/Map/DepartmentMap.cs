using eManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eManagement.Data.Map
{
    public class DepartmentMap : IEntityTypeConfiguration<eManagementLeadEntity>
    {
        public void Configure(EntityTypeBuilder<eManagementLeadEntity> builder)
        {
           builder.HasKey(x => x.Id);
           builder.HasOne(x => x.Department);
        }
    }

}
