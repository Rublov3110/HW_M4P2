using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW_M4L3
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
                .ToTable("Title")
                .HasKey(p => p.ID);

            builder.Property(p => p.Name)
                .HasColumnType("nvarchar(50)");
        
        }
    }
}
