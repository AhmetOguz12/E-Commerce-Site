using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Concigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.ProductName).HasMaxLength(50);

            Product product1 = new Product()
            {
                Id = Guid.Parse("77e9f1ec-32dd-4c7d-b269-e33267845a96"),
                CategoryId = Guid.Parse("F076FB93-5369-4623-9DB0-A6834A2A3374"),
                Description = "Telefon Sadece 1 Kez Açıldı",
                ProductName = "Iphone 3",
                UnitPrice = 8500
            };
            Product product2 = new Product()
            {
                Id = Guid.Parse("65e9f1ec-32dd-4c7d-b269-e33267845a96"),
                CategoryId = Guid.Parse("5576255C-5C4E-429E-962A-5E5D1A929547"),
                Description = "Telefon Sadece 1 Kez Açıldı",
                ProductName = "Acer Bilgisayar",
                UnitPrice = 12000
            };
            builder.HasData(product1, product2);
        }
    }
}
