using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RemTechStroy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult _Layout()
        {
            return View();
        }
    }
}