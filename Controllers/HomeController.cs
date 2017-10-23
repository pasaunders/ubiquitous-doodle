using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace timeDisplay.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            String storingTime = DateTime.Now.ToString("MMMM d, yyyy hh:mm");
            ViewData["Time"] = storingTime;
            return View();
        }
    }
}
