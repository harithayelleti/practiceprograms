using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace StudentMVCentity.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("ProductionConnection")
        {


        }
        public DbSet<Student> StudentTable { get; set; }
    }
}