using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GardnerWebApplication.Models
{
    //Blog (Id, Title, Body, Alias, StartDate)
    public class Blog
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z-\s]*$")]
        [Required]
        [StringLength(100)]
        public string Alias { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
    }
}
