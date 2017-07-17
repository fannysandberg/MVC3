using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc3.Models
{
    public class PeopleCreateVM
    {

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email")]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "What is 2 + 2?")]
        [Range(4, 4, ErrorMessage = "Not convinced. Return as a human being or learn math.")]
        public int BotCheck { get; set; }
    }
}
