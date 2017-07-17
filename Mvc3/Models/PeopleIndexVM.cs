using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc3.Models
{
    public class PeopleIndexVM
    {
        [Display(Name = "First name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }
        public int Id { get; set; }

        public bool ShowAsHighLighted { get; set; }
    }
}
