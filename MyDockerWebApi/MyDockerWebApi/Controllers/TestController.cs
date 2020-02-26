using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyDockerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get Worked!");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Get with id {id} worked!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return BadRequest("Something went horribly wrong!");
            }
            return Ok($"Post worked with {value}");
        }
    }
}