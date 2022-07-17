using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW_M4L3
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .ToTable("Project")
                .HasKey(p => p.ID);

            builder.Property(p => p.Name)
             .HasColumnType("nvarchar(50)");

            builder.Property(p => p.Budget)
              .HasColumnType("money");

            builder.Property(p => p.StartedDate)
              .HasColumnType("datetime2(7)");

            builder.HasData(
               new Project() { ID = 1, Name = "First project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-7) },
               new Project() { ID = 2, Name = "Second project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-570)},
               new Project() { ID = 3, Name = "Third project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-100)},
               new Project() { ID = 4, Name = "Fourth project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-50)},
               new Project() { ID = 5, Name = "Fifth project", Budget = 1000, StartedDate = DateTime.Now.AddDays(-180)});
        }
    }
}
