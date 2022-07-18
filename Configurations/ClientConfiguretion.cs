using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW_M4L3
{
    public class ClientConfiguretion : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("Client")
                .HasKey(p => p.ID);

            builder.HasData(
                new Client() { ID = 1, Email = "firstBox@gmail.com", Title = "Microsoft", CountryFrom = "USA", PhoneNumber = 111111 },
                new Client() { ID = 2, Email = "secondBox@gmail.com", Title = "Google", CountryFrom = "Germany", PhoneNumber = 222222 },
                new Client() { ID = 3, Email = "third@gmail.com", Title = "Apple", CountryFrom = "Denmark", PhoneNumber = 333333 },
                new Client() { ID = 4, Email = "fourthBox@gmail.com", Title = "Tesla", CountryFrom = "Ukraine", PhoneNumber = 444444 },
                new Client() { ID = 5, Email = "fifthBox@gmail.com", Title = "Amazon", CountryFrom = "Turkey", PhoneNumber = 555555 });
        }
    }

}
