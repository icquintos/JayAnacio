using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicCRUD.Models;

namespace BasicCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetEmployee()
        {
            return View();
        }


        public ActionResult RegisterEmployee()
        {
            return View();
        }

        [HttpPost]
        [ActionName("RegisterEmployee")]
        public ActionResult Register(Employee employee)
        {

            if(ModelState != null)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.Employee.Add(employee);
                    db.SaveChanges();
                }

                ModelState.Clear();
                ViewBag.Message = employee.Firstname + " " + employee.Lastname + " successfully added.";
            }
            return View();
        }


    }
}