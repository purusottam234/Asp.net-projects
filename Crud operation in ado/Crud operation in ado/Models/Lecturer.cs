using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
using System.ComponentModel.DataAnnotations;


namespace Crud_operation_in_ado.Models
{
    public class Lecturer
    {
        public int Id { get; set; }

        [Required]
        public string LecturerName { get; set; }

        [Required]
        [SkillsValidate(Allowed = new string[] { "ASP.NET Core", "ASP.NET MVC", " Web Forms" }, ErrorMessage = "You skills are invalid")]
        public string Skills { get; set; }

        [Range(5, 50)]
        public int NoofStudents { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
