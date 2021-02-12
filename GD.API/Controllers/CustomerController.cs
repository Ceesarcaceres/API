using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GD.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //GET api
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpPost]
        public IActionResult Post([FromBody] CustomerViewModel customer)
        {
            return Ok(customer);
        }
        //[HttpPost]
        //public int Add(int number1, int number2)
        //{
        //    return number1 + number2;
        //}

        //// GET api/
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "customer";
        //}

    }
}