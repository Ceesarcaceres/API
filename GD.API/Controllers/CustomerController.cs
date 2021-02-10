using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET api
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "customer";
        }

        //POST api/
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}