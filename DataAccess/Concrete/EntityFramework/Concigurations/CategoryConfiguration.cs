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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new Category
            {
                Id = Guid.Parse("F076FB93-5369-4623-9DB0-A6834A2A3374"),
                CategoryName = "Telefon"
            };
            Category category2 = new Category
            {
                Id = Guid.Parse("5576255C-5C4E-429E-962A-5E5D1A929547"),
                CategoryName = "Bilgisayar"
            };

            builder.HasData(category1,category2);
     
        }
    }
}
