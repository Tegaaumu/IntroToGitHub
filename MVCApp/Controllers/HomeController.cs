using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogis.EmpoyeeProcessor;
using MVCApp.Models;

namespace MVCApp.Controllers
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

        public ActionResult ViewEmployee()
        {
            ViewBag.Message = "List of registered user's";

            var dataAccess = LoadEmployees();
            List<EmployeeModel> employee = new List<EmployeeModel>();

            foreach (var teg in dataAccess)
            {
                employee.Add(new EmployeeModel
                {
                    EmployeeId = teg.EmployeeID,
                    FirstName = teg.FirstName,
                    LastName = teg.LastName,
                    EmailAdress = teg.EmailAdress,
                    ConfirmEmail = teg.EmailAdress
                });
            }

            return View(employee);
        }

        public ActionResult SinUp()
        {
            ViewBag.Message = "Suin Up Employee";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SinUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordCreated = CreateEmployee(
                    model.EmployeeId,
                    model.FirstName,
                    model.LastName,
                    model.EmailAdress);
                return RedirectToAction("index");
            }
            return View();
        }
    }
}