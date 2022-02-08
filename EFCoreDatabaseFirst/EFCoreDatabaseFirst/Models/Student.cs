using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDatabaseFirst.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
