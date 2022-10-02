using Java.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Listing_MAUI_Application.Models
{
    public class User
    {
        public int Id { get; set; }
        public Guid UserId { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }

    }
}
