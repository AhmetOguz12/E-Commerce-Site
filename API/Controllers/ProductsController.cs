using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet("getall")]
        //[Authorize(Roles = "userRole")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getproductdetaildto")]
        public ActionResult Get()
        {
            var result = _productService.GetProductDetailDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getproductdetaildtobyıd")]
        public ActionResult GetProductDetailDtoById(Guid id)
        {
            var result = _productService.GetProductDetailDtoById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getproductdetaildtobycategoryıd")]
        public ActionResult GetProductDetailDtoByCategoryId(Guid categoryId)
        {
            var result = _productService.GetProductDetailDtoByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public ActionResult Add(AddProductDto addProductDto)
        {
            var result = _productService.Add(addProductDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete()]
        [Route("delete/{id}")]
        public ActionResult Delete(Guid id)
        {
            var result = _productService.Delete(new Product
            {
                Id = id
            });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public ActionResult Update(UpdateProductDto updateProductDto)
        {
            var result = _productService.Update(updateProductDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
