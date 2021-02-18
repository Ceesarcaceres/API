using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GD.UI.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Customer()
        {
            return View();
        }
        [HttpPost]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}