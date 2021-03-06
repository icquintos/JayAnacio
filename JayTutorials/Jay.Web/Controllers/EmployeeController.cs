﻿using Jay.Manager.DataManager;
using Jay.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jay.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeManager _employeeManager = new EmployeeManager();

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddEmployee(AddEmployeeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newEmployee = model.ParseToDataModel();
                    _employeeManager.AddEmployee(newEmployee);
                }
                else
                {
                    // ERROR
                }
            }
            catch
            {
                throw;
            }

            return View(model);
        }
    }
}