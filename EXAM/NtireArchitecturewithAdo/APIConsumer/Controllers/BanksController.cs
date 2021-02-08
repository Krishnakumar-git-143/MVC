using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsumer.Controllers
{
    public class BanksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Jquery()
        {
            return View();
        }
    }
}
