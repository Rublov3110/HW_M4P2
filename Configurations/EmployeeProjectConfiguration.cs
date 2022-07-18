using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW_M4L3
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
                .ToTable("EmployeeProject")
                .HasKey(p => p.ID);

            builder.Property(p => p.Rate)
               .HasColumnType("money");

            builder.Property(p => p.StartedDate)
               .HasColumnType("datetime2(7)");
        }
    }
}
