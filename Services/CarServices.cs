using Car_Listing_MAUI_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Listing_MAUI_Application.Services
{
    public class CarServices
    {

        public List<Car> getCars()
        {
            return new List<Car>()
           {
               new Car
               {
                   Id=1, Make="Toyota", Model="Corolla", Vin="1234"
               },
                new Car
               {
                   Id=2, Make="Toyota", Model="Venza", Vin="1332"
               },
                 new Car
               {
                   Id=3, Make="Toyota", Model="Mountain Machine", Vin="6755"
               },
                  new Car
               {
                   Id=4, Make="Tesla", Model="P3", Vin="2222"
               },
                   new Car
               {
                   Id=5, Make="Benz", Model="Machine", Vin="1234"
               },
                    new Car
               {
                   Id=6, Make="Honda", Model="Prada", Vin="1234"
               },
                     new Car
               {
                   Id=7, Make="BMW", Model="Basmati Rice", Vin="9084"
               },
           };
        }
    }
}
