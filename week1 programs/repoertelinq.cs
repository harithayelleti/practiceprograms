using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelinq
{
    class emplinq
    {
        static void Main(string[] args)
        {
            List<reporting> rlist = new List<reporting>()
            { 
  
          //4 Emplyees //4ID //4Name //4salary //4designation
           new reporting(){ RId = 1, ReporterName = "Archana",Designation = "DatabaseAdmin"},
            new reporting() { RId  = 2,ReporterName = "kavya", Designation = "Developer" },
            new reporting() { RId  = 3,ReporterName= "bala",  Designation = "Testing" },
            new reporting() { RId = 4, ReporterName= "sruthi", Designation = "Manager" },
            new reporting() { RId = 5, ReporterName = "hari", Designation = "AssManager" },
            };

            List<Department> dlist = new List<Department>()
            {
              new Department(){ DeptId= 1, DeptName = "cse",Designation = "DatabaseAdmin"},
              new Department(){ DeptId = 2, DeptName = "Business",Designation = "Developer"},
              new Department(){ DeptId = 3, DeptName = "ece",Designation = "Testing"},
              new Department(){ DeptId = 4, DeptName = "mca", Designation = "Manager"},
            };


            var reportername = rlist.Where(e => e.Designation = 'Testing').Select(e => e).Where(e => e.RId > 1).Select(e => e.ReporterName);//O/P:kavya,bala,sruthi
            var reportername1 = rlist.Where(e => e.Designation = 'Manager').Select(e => e).Where(ds => ds.RId == 1).Select(e => e.ReporterName);//O/P:Archana


            var repname2 = from e in rlist
                           where e.RId > 4 && e.RId< 5
                           select new { reporterName = e.ReporterName };
            repname2.ToList().ForEach(s => Console.WriteLine(s.reporterName));//O/P:archana,bala,sruthi



            var empGroupbyId = from e in rlist
                               group e by e.RId into ep  //ep =>to store this group in another alias
                               orderby ep.Key
                           select new{ ep.Key, ep };//O/P:EmpId:1,EmpId:2,EmpId:3,EmpId:4,EmpId:5


            

            //joins
            var join = from e1 in rlist
                       join d1 in dlist
                       on e1.RId equals d1.DeptId

                       select new
                       {
                           Name = e1.ReporterName,
                           Des = d1.Designation,
                       };




           

            foreach (var x in join)
            {
                Console.WriteLine("ReporterName" + x.Name + " " + "Designation" + x.Des);
                Console.ReadKey();
            }

            



            foreach (var group in empGroupbyId)
            {
                Console.WriteLine("EmpId {0}:", group.Key);
            }
            


            foreach (var name in reportername)
            {
                Console.WriteLine(name);
            }

            foreach (var result in reportername1)
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }

        public class reporting
        {
            public int RId { get; set; }

            public string ReporterName { get; set; }
            
            public string Designation { get; set; }
        }
        public class Department
        {
            public int DeptId { get; set; }

            public string DeptName { get; set; }

            public string Designation { get; set; }
        }
    }
}


