using Bussiness.Abstract;
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
    public class RentedCarsController : ControllerBase
    {
        IRentedCarsService _rentedCarsService;

        public RentedCarsController(IRentedCarsService rentedCarsService)
        {
            _rentedCarsService = rentedCarsService;
        }

        [HttpGet]
        public IActionResult GetAll() { var result = _rentedCarsService.GetAll();
            if (result.success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Messages);
        }

    }
}
