using ConstellationDeploymentServer.Data;
using ConstellationDeploymentServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstellationDeploymentServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("{customer/{id}/product}")]
        public IActionResult GetAllConsumerProducts()
        {
            try
            {
                List<Product> ProductList = new List<Product>();
                List<Product> list1 = DataAccess.GetConsumerProducts(); //GetConsumerProducts should be implemented in DataAccess class
                ProductList = list1;
                return Ok(ProductList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpGet("{customer/{id}/product/{id}}")]
        public IActionResult GetConsumerProductInfoById(int id)
        {
            try
            {
                List<Product> ProductList = new List<Product>();
                List<Product> list1 = DataAccess.GetConsumerProductById(id); //GetConsumerProductById should be implemented in DataAccess class
                ProductList = list1;
                return Ok(ProductList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPost("{customer/{id}/product}")]
        public IActionResult CreateANewProduct()
        {
            try
            {
                List<Product> ProductList = new List<Product>();
                List<Product> list1 = DataAccess.CreateProduct(); //CreateProduct should be implemented in DataAccess class
                ProductList = list1;
                return Ok(ProductList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPut("{customer/{id}/product/{id}}")]
        public IActionResult UpdateConsumerProductInfo(int id)
        {
            try
            {
                List<Product> productList = new List<Product>();
                List<Product> list1 = DataAccess.UpdateProductInfo(id); //UpdateProductInfo should be implemented in DataAccess class
                productList = list1;
                return Ok(productList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
