using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTutorialApp.Models
{
    public class Contact
    {
        [Required]
        public int Id { get; set; }

        [MinLength(2), MaxLength(50)]
        public string FirstName { get; set; }

        [MinLength(2), MaxLength(50)]
        public string LastName { get; set; }
    }
}
