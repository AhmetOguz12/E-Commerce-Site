using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class productManager : IProductService
    {
        IProductDal _productDal;
        ICategoryDal _categoryDal;

        public productManager(IProductDal productDal, ICategoryDal categoryDal)
        {
            _productDal = productDal;
            _categoryDal = categoryDal;
        }

        public IResult Add(AddProductDto product)
        {

            var newProduct = new Product
            {
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                Description = product.Description,
                CategoryId = product.CategoryId
            };
            _productDal.Add(newProduct);
            return new SuccessResult("Ürün Eklendi");
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Ürün Silindi");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailDto()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.ProductDetailDto());
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailDtoByCategoryId(Guid categoryId)
        {
            var products = _productDal.GetAll(x => x.CategoryId == categoryId);
            var category = _categoryDal.GetAll();

            var productDetailDtoByCategoryId = products.Select(listproduct => new ProductDetailDto
            {
                CategoryName = category.FirstOrDefault(x => x.Id == listproduct.CategoryId)?.CategoryName ?? "",
                Description = listproduct.Description,
                ProductName = listproduct.ProductName,
                UnitPrice = listproduct.UnitPrice,
            }).ToList();
            return new SuccessDataResult<List<ProductDetailDto>>(productDetailDtoByCategoryId);
        }

        public IDataResult<ProductDetailDto> GetProductDetailDtoById(Guid id)
        {
            var products = _productDal.GetAll();
            var category = _categoryDal.GetAll();

            var productDetailDtoById = products.Where(x => x.Id == id).Select(listproducts => new ProductDetailDto
            {
                ProductId=id,
                ProductName = listproducts.ProductName,
                UnitPrice = listproducts.UnitPrice,
                Description = listproducts.Description,
                CategoryName = category.FirstOrDefault(c => c.Id == listproducts.CategoryId)?.CategoryName ?? "",
            }).FirstOrDefault();
            return new SuccessDataResult<ProductDetailDto>(productDetailDtoById);
        }

        public IResult Update(UpdateProductDto product)
        {
            var newProduct = new Product
            {
                Id = product.Id,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                Description = product.Description,
                CategoryId = product.CategoryId,
            };
            _productDal.Update(newProduct);
            return new SuccessResult("Ürün Güncellendi");
        }
    }
}
