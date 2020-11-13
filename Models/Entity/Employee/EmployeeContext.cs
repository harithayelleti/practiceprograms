using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

using EmployeeMVCEntity.Models;


namespace EmployeeMVCEntity.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
           : base("ProductionConnection")
        {


        }
        public DbSet<Employee> EmployeeTable { get; set; }

    }
}