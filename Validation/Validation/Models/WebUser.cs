using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Models
{
    public class WebUser
    {
        [Required]

        public int RollNo { get; set; }
        [Required]

        [StringLength(25)]
        [Display(Name="First Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]

        public string Address { get; set; }
        [Required]
        [StringLength(25)]

        public int Phone { get; set; }
    }
}
