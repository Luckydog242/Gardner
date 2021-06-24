using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GardnerWebApplication.Models
{
    //Author (Id, Title, FirstName, LastName) 
    public class Author
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

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
