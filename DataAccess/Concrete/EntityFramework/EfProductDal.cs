
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, Context>, IProductDal
    {
        public List<ProductDetailDto> ProductDetailDto()
        {
            using (Context context = new Context())
            {
                var result = from product in context.Products
                             join category in context.Categories
                             on product.CategoryId equals category.Id
                             select new ProductDetailDto
                             {
                                 ProductId = product.Id,
                                 ProductName = product.ProductName,
                                 CategoryName = category.CategoryName,
                                 Description = product.Description,
                                 UnitPrice = product.UnitPrice,
                                 
                             };
                return result.ToList();
            }

        }
    }
}
