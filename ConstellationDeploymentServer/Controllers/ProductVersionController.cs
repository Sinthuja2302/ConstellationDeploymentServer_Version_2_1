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
    public class ProductVersionController : ControllerBase
    {
        [HttpGet("{customer/{id}/product/{id}/ProductVersion}")]
        public IActionResult GetAllProductVersion()
        {
            try
            {
                List<ProductVersion> ProductVersionList = new List<ProductVersion>();
                List<ProductVersion> list1 = DataAccess.GetProductVersion(); //GetProductVersion should be implemented in DataAccess class
                ProductVersionList = list1;
                return Ok(ProductVersionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpGet("{customer/{id}/product/{id}/ProductVersion/{id}}")]
        public IActionResult GetProductVersionInfoById(int id)
        {
            try
            {
                List<ProductVersion> ProductVersionList = new List<ProductVersion>();
                List<ProductVersion> list1 = DataAccess.GetProductVersionById(id); //GetProductVersionById should be implemented in DataAccess class
                ProductVersionList = list1;
                return Ok(ProductVersionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpGet("{customer/{id}/product/{id}/ProductVersion/{latest}}")]
        public IActionResult GetProductVersionLatest(string latest)
        {
            try
            {
                List<ProductVersion> ProductVersionList = new List<ProductVersion>();
                List<ProductVersion> list1 = DataAccess.GetProductVersionLatestOne(); //GetProductVersionLatestOne should be implemented in DataAccess class
                ProductVersionList = list1;
                return Ok(ProductVersionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpGet("{customer/{id}/product/{id}/ProductVersion/{id}/{download}}")]
        public IActionResult DownloadProductVersionById(string download)
        {
            try
            {
                List<ProductVersion> ProductVersionList = new List<ProductVersion>();
                List<ProductVersion> list1 = DataAccess.DownloadProductVersionById(); //DownloadProductVersionById should be implemented in DataAccess class
                ProductVersionList = list1;
                return Ok(ProductVersionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPost("{customer/{id}/product/{id}/ProductVersion}")]
        public IActionResult CreateANewProductVersion()
        {
            try
            {
                List<ProductVersion> ProductVersionList = new List<ProductVersion>();
                List<ProductVersion> list1 = DataAccess.CreateNewProductVersion(); //CreateNewProductVersion should be implemented in DataAccess class
                ProductVersionList = list1;
                return Ok(ProductVersionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPut("{customer/{id}/product/{id}/ProductVersion/{id}}")]
        public IActionResult UpdateProductVersionInfo(int id)
        {
            try
            {
                List<ProductVersion> productVersionList = new List<ProductVersion>();
                List<ProductVersion> list1 = DataAccess.UpdateProductVersion(id); //UpdateProductVersion should be implemented in DataAccess class
                productVersionList = list1;
                return Ok(productVersionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
