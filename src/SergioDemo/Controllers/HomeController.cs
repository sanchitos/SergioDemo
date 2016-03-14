using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SergioDemo.Models;
using SergioDemo.Services.Interfaces;

namespace SergioDemo.Controllers
{
    public class HomeController : Controller
    {
        public IEmailService _service;
        public HomeController(IEmailService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page." + Startup.Configuration["Site:MaxUsers"];

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var fromEmail = Startup.Configuration["Site:ContactTo"];
                ViewBag.Message = "Your information has been sent to: " + model.Email;
                _service.SendEmail(fromEmail, model.Email, model.Name, model.Comment);

                return RedirectToAction("Contact");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error");
                return View();
            }                
            
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
