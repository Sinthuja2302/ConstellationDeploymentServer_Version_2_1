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
    public class CustomerController : ControllerBase
    {
        //GET api/customer , GET / customers (Get all the customers)
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            try
            {
                List<Customer> customerList = new List<Customer>();
                List<Customer> list1 = DataAccess.GetCustomers();
                customerList = list1;
                return Ok(customerList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        //GET api/customer/5 , GET / customers/{id} (Get the Customer Info with the Id received on the URL)
        [HttpGet("{id}")]
        public IActionResult GetCustomerInfoById(int id)
        {
            try
            {
                List<Customer> customerList = new List<Customer>();
                List<Customer> list1 = DataAccess.GetCustomerById(id);
                customerList = list1;
                return Ok(customerList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        ////POST api/customer , POST / customers - create customer (will receive the customer data as a payload on the body of the request)
        [HttpPost]
        public IActionResult CreateCustomer()
        {
            try
            {
                List<Customer> customerList = new List<Customer>();
                List<Customer> list1 = DataAccess.CreateCustomer();
                customerList = list1;
                return Ok(customerList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        ////PUT api/customer/5 , PUT / customers/{id} - update customer info (will receive the NEW data of the customer as a payload on the body of the request)
        [HttpPut("{id}")]
        public IActionResult UpdateCustomerInfo(int id)
        {
            try
            {
                List<Customer> customerList = new List<Customer>();
                List<Customer> list1 = DataAccess.UpdateCustomer(id);
                customerList = list1;
                return Ok(customerList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
