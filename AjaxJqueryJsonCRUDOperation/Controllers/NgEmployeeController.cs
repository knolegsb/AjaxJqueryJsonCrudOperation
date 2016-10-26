using AjaxJqueryJsonCRUDOperation.EF;
using AjaxJqueryJsonCRUDOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxJqueryJsonCRUDOperation.Controllers
{
    public class NgEmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployee()
        {
            CrudOpDbContext db = new CrudOpDbContext();
            List<Employee> ListOfEmployee = new List<Employee>();
            ListOfEmployee = db.Employees.ToList();

            return Json(ListOfEmployee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveEmployee(Employee _oEmployee)
        {
            CrudOpDbContext db = new CrudOpDbContext();
            db.Employees.Add(_oEmployee);
            db.SaveChanges();

            List<Employee> ListOfEmployee = db.Employees.ToList();
            return Json(ListOfEmployee, JsonRequestBehavior.AllowGet);
        }

        //public PartialViewResult Create()
        //{
        //    return PartialView("Create");
        //}

        //[HttpPost]
        //public JsonResult Create(Employee employee)
        //{
        //    CrudOpDbContext db = new CrudOpDbContext();

        //    db.Employees.Add(employee);
        //    db.SaveChanges();
        //    return Json(employee, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //public PartialViewResult Edit(int? ID)
        //{
        //    CrudOpDbContext db = new CrudOpDbContext();
        //    Employee employee = new Employee();
        //    employee = db.Employees.Find(ID);
        //    return PartialView(employee);
        //}

        //[HttpPost]
        //public JsonResult Edit(Employee employee)
        //{
        //    CrudOpDbContext db = new CrudOpDbContext();
        //    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
        //    db.SaveChanges();
        //    return Json(employee, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //public JsonResult Delete(int ID)
        //{
        //    CrudOpDbContext db = new CrudOpDbContext();
        //    Employee employee = new Employee();
        //    employee = db.Employees.Find(ID);
        //    db.Entry(employee).State = System.Data.Entity.EntityState.Deleted;
        //    db.SaveChanges();
        //    return Json(employee, JsonRequestBehavior.AllowGet);
        //}
    }
}