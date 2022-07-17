using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW_M4L3
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
                .ToTable("Office")
                .HasKey(p => p.ID);

            builder.Property(p => p.Title)
                .HasColumnType("nvarchar(100)");

            builder.Property(p => p.Location)
                .HasColumnType("nvarchar(100)");
        }
    }
}
