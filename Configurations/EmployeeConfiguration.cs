using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW_M4L3
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("Employee")
                .HasKey(p => p.ID);

            builder.Property(p => p.DateOfBirth)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(p =>p.FirstName)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.LastName)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.HiredDate)
                .HasColumnType("datetime2(7)");

        }
    }
}
