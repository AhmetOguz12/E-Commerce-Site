using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetProductDetailDto();
        IDataResult<ProductDetailDto> GetProductDetailDtoById(Guid id);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtoByCategoryId(Guid categoryId);
        IResult Add(AddProductDto product);
        IResult Delete(Product product);
        IResult Update(UpdateProductDto product);
    }
}

