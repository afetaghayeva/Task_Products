using Microsoft.AspNetCore.Mvc;
using System;
using Task1.DataAccess;
using Task1.Logging;
using Task1.Model;

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductDal _productDal;
        private readonly IMyLogger _logger;

        public ProductsController(IProductDal productDal, IMyLogger logger)
        {
            _productDal = productDal;
            _logger = logger;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            _logger.Log($"Products list called at {DateTime.Now}");
            var result = _productDal.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Products cannot list");
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            _logger.Log($"{id}th product  called at {DateTime.Now}");
            var result = _productDal.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Product not found");
        }

        [HttpPost("add")]
        public void Add(Product product)
        {
            _logger.Log($"Product added at {DateTime.Now}");
            _productDal.Add(product);
        }

        [HttpPost("update")]
        public void Update(Product product)
        {
            _logger.Log($"Product updated at {DateTime.Now}");
            _productDal.Update(product);
        }

        [HttpPost("delete/{id}")]
        public void Delete(int id)
        {
            _logger.Log($"{id}th product delete at {DateTime.Now}");
            _productDal.Delete(id);
        }
    }
}
