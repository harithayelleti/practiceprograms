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
            List<Employee> elist = new List<Employee>()
            { 
  
          //4 Emplyees //4ID //4Name //4salary //4designation
           new Employee(){ EmpId = 1, EmployeeName = "Archana", Salary = 27000,Designation = "DatabaseAdmin"},
            new Employee() { EmpId  = 2, EmployeeName = "kavya", Salary = 2000, Designation = "Developer" },
            new Employee() { EmpId  = 3,EmployeeName = "bala", Salary = 25000, Designation = "Testing" },
            new Employee() { EmpId = 4, EmployeeName = "sruthi", Salary = 24000, Designation = "Manager" },
            new Employee() { EmpId = 5, EmployeeName = "hari", Salary = 29000, Designation = "AssManager" },
            };

            List<Department> dlist = new List<Department>()
            {
              new Department(){ DeptId= 1, DeptName = "cse",Designation = "DatabaseAdmin"},
              new Department(){ DeptId = 2, DeptName = "Business",Designation = "Developer"},
              new Department(){ DeptId = 3, DeptName = "ece",Designation = "Testing"},
              new Department(){ DeptId = 4, DeptName = "mca", Designation = "Manager"},
            };


            var empname = elist.Where(e => e.Salary < 27000).Select(e => e).Where(e => e.EmpId > 1).Select(e => e.EmployeeName);//O/P:kavya,bala,sruthi
            var empname1 = elist.Where(e => e.Salary > 25000).Select(e => e).Where(ds => ds.EmpId == 1).Select(e => e.EmployeeName);//O/P:Archana
            

            var empname2 = from e in elist
                                   where e.Salary > 2000 && e.Salary < 29000
                           select new { EmployeeName = e.EmployeeName };
            empname2.ToList().ForEach(s => Console.WriteLine(s.EmployeeName));//O/P:archana,bala,sruthi



            var empGroupbyId = from e in elist group e by e.EmpId into ep  //ep =>to store this group in another alias
                                       orderby ep.Key
                                       select new { ep.Key, ep };//O/P:EmpId:1,EmpId:2,EmpId:3,EmpId:4,EmpId:5


            var empGroupBy = from e in elist where e.Salary > 2000 // One Query statement
                                             where e.EmpId > 1//Another query statement
                                             group e by e.EmpId into ep
                                             orderby ep.Key
                                             select new { ep.Key, ep };//O/P:EmpId:3,EmpId:4,EmpId:5  
            
            //joins
            var join = from e1 in elist
                       join d1 in dlist
                       on e1.EmpId equals d1.DeptId

                       select new
                       {
                           Name = e1.EmployeeName,
                           Des = d1.Designation,
                       };




            var rightjoin = from e1 in elist
                       join d1 in dlist
                       on e1.EmpId equals d1.DeptId

                       select new
                       {
                           Name = e1.EmpId,
                           Des = d1.Designation,
                       };

            foreach (var x in join)
            {
                Console.WriteLine("EmployeeName" + x.Name + " " + "Designation" + x.Des);
                Console.ReadKey();
            }

            foreach (var l in rightjoin)
            {
                Console.WriteLine("EmpId" + l.Name + " " + "Designation" + l.Des);
                Console.ReadKey();
            }



            foreach (var group in empGroupbyId)
            {
                Console.WriteLine("EmpId {0}:", group.Key);
            }
            foreach (var group in empGroupBy)
            {
                Console.WriteLine("EmpId {0}:", group.Key);
            }


            foreach (var name in empname)
            {
                Console.WriteLine(name);
            }

            foreach (var result in empname1)
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }

            public class Employee
        {
            public int EmpId { get; set; }

            public string EmployeeName { get; set; }
            public int Salary { get; set; }
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


