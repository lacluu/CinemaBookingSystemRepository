using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApplication.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "Min length is 5 character!")]
        public String Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "This email is not correct syntax!")]
        public String Email { get; set; }
        [Required]
        public String Subject { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Message too long")]
        public String Message { get; set; }
    }
}
