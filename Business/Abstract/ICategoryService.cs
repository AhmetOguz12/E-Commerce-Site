using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
         IDataResult<List<Category>> GetAll();
        IDataResult<CategoryDetailDto> GetCategoryDtoById(Guid id);
        IDataResult<List<CategoryDetailDto>> GetCategoryDto();
        IResult Add(AddCategoryDto category);
        IResult Update(UpdateCategoryDto category);
        IResult Delete(Category category);

    }
}
