using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Listing_MAUI_Application.Models
{
    public class Car:BaseModel
    {
        
        public string Make { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
       
        public User UserId { get; set; }
        

    }
}
