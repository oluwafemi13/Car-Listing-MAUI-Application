using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Listing_MAUI_Application.Models
{
    public class Car
    {
        public int Id { get; set; }
        public Guid userId = Guid.NewGuid();
        public string Make { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }

    }
}
