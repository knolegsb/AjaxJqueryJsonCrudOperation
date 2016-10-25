using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxJqueryJsonCRUDOperation.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public decimal EmployeeSalary { get; set; }
    }
}