using CinemaWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApplication.Controllers
{
    public class AppController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.UserMessage = "Sent Message Success!";
            }
            return View();
        }
        
    }
}
