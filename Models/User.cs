//using Java.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Listing_MAUI_Application.Models
{
    public class User:BaseModel
    {

        public Guid UserId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }
        
        public string Password { get; set; }

    }
}
