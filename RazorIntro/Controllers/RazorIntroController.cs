using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorIntro.Controllers
{
    public class RazorIntroController : Controller
    {
        // GET:
        public IActionResult Index()
        {
            return View();
        }
    }
}