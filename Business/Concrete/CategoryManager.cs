using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(AddCategoryDto category)
        {
            Category newCategory = new Category
            {
                CategoryName = category.CategoryName,
                CreateTime = category.CreateTime,
            };
            _categoryDal.Add(newCategory);
            return new SuccessResult("Ürün Eklendi");
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult("Kategori Silindi");

        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<List<CategoryDetailDto>> GetCategoryDto()
        {
            var category = _categoryDal.GetAll();
            var categoryDetailDto = category.Select(listcategory => new CategoryDetailDto
            {
                CategoryName = listcategory.CategoryName,
                CreateTime = listcategory.CreateTime
            }).ToList();
            return new SuccessDataResult<List<CategoryDetailDto>>(categoryDetailDto);
        }

        public IDataResult<CategoryDetailDto> GetCategoryDtoById(Guid id)
        {
            var category = _categoryDal.GetAll();

            var categoryDetailDtoById = category.Where(x => x.Id == id).Select(listcategory => new CategoryDetailDto
            {
                CategoryName = listcategory.CategoryName,
                CreateTime = listcategory.CreateTime,
            }).FirstOrDefault();
            return new SuccessDataResult<CategoryDetailDto>(categoryDetailDtoById);
        }

        public IResult Update(UpdateCategoryDto category)
        {
            Category newCategory = new Category
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                CreateTime = category.CreateTime
            };
            _categoryDal.Update(newCategory);
            return new SuccessResult("Kategori Güncellendi");
        }


 }

    
    }

