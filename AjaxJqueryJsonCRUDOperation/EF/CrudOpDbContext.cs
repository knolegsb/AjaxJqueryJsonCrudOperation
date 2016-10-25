using AjaxJqueryJsonCRUDOperation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxJqueryJsonCRUDOperation.EF
{
    public class CrudOpDbContext : DbContext
    {
        public CrudOpDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            modelBuilder.Entity<Employee>().HasKey(x => x.EmployeeID);
        }
    }
}