using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();

            if (result.success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Messages);
        }


        [HttpPost("Delete")]
        public IActionResult DeleteCustomer(Customer customer)
        {

            var result = _customerService.Delete(customer);
            if (result.success)
            {
                return Ok(result.Messages);
            }
            return BadRequest(result.Messages);

        }

        [HttpPost("Update")]
        public IActionResult UpdateCustomer(Customer customer)
        {

            var result = _customerService.Update(customer);
            if (result.success)
            {
                return Ok(result.Messages);
            }
            return BadRequest(result.Messages);

        }

    }
}
