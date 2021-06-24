using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GardnerWebApplication.Models
{
    public class Alias
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z-\s]*$")]
        [Required]
        [StringLength(100)]
        public string AliasName { get; set; }

        [Display(Name = "First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]\-*$")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]\-*$")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
    }
}
