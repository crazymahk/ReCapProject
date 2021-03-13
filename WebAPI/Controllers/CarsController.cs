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
    public class CarsController : ControllerBase
    {

        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.success)
            {
                return Ok(result);
            }

            return BadRequest(result.Messages);
        }
        [HttpGet("GetCarDetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarsDdetails();
            if (result.success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messages);
        }

        [HttpPost("GetCarBrandId")]
        public IActionResult GetCarDetails(int brandid)
        {
            var result = _carService.GetCarsByBrandId(brandid);
            if (result.success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messages);
        }
    }
}
