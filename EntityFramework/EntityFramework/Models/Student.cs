using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Student
    {
        [Key]
        public int sid { get; set; }
        public String name { get; set; }
        public string address { get; set; }
        public int age { get; set; }

    }
}
