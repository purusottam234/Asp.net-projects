using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations

namespace EFcoreCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
}
