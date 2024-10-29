using Microsoft.AspNetCore.Mvc;
using ProductMicroservices.Models;
using ProductMicroservices.Repository;
//using System;
//using System.Collections.Generic;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    //{
    //    private readonly IProductRepository _productRepository;

    // public ProductController(IProductRepository productRepository)
    // {
    //   _productRepository = productRepository;
    // }

    //// GET: api/<ProductController>
    //[HttpGet]
    //    public IEnumerable<string> Get()
    //    {
    //        var products = _productRepository.GetProducts();
    //        return new OkObjectResult(products);

    //        //return new string[] { "value1", "value2" };
    //    }

    //    // GET api/<ProductController>/5
    //    [HttpGet("{id}")]
    //    public string Get(int id)
    //{
    //    var product = _productRepository.GetProductByID(id);
    //    return new OkObjectResult(product);

    //    //return "value";
    //}

    //    // POST api/<ProductController>
    //    [HttpPost]
    //    public void Post([FromBody] string value)
    //    {
    //        using (var scope = new TransactionScope())
    //        {
    //            _productRepository.InsertProduct(product);
    //            scope.Complete();
    //            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    //        }
    //    }

    //    // PUT api/<ProductController>/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody] string value)
    //    {
    //        if (product != null)
    //        {
    //            using (var scope = new TransactionScope())
    //            {
    //                _productRepository.UpdateProduct(product);
    //                scope.Complete();
    //                return new OkResult();
    //            }
    //        }
    //        return new NoContentResult();
    //    }



    //}

    //// DELETE api/<ProductController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //    _productRepository.DeleteProduct(id);
    //    return new OkResult();

    //}







    {

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _productRepository.GetProducts();
            return new OkObjectResult(products);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var product = _productRepository.GetProductById(id);
            return new OkObjectResult(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            using (var scope = new TransactionScope())
            {
                _productRepository.InsertProduct(product);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            if (product != null)
            {
                using (var scope = new TransactionScope())
                {
                    _productRepository.UpdateProduct(product);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productRepository.DeleteProduct(id);
            return new OkResult();
        }
    }
}
