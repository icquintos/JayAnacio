using JayTutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayTutorials.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            // Pwde ka gumawa ng model dito tapos return View(model) mo.

            //var model = new RegisterViewModel();
            //return View(model);

            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            // break point here, check model value should reflect POSTED value
            // Save this to Database

            // You can test by changing model value then return it to VIEW
            //model.Name = "Jay";
            //model.EmailAddress = "Jay@Test.com";

            // Add model in View to display the MODEL value in the VIEW page
            return View(model);
        }
    }
}