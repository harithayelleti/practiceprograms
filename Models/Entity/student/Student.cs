using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentMVCentity.Models
{
    //[Table("tblStudent")]
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string City { get; set; }
    }
}