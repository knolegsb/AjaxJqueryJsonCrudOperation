using AjaxJqueryJsonCRUDOperation.EF;
using AjaxJqueryJsonCRUDOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxJqueryJsonCRUDOperation.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployeeDetails()
        {
            CrudOpDbContext db = new CrudOpDbContext();
            List<Employee> ListOfEmployee = new List<Employee>();
            ListOfEmployee = db.Employees.ToList();

            return Json(ListOfEmployee, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public JsonResult Create(Employee employee)
        {
            CrudOpDbContext db = new CrudOpDbContext();

            db.Employees.Add(employee);
            db.SaveChanges();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }
    }
}