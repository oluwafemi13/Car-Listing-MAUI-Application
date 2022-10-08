using Android.OS;
using Car_Listing_MAUI_Application.Models;
using Car_Listing_MAUI_Application.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Listing_MAUI_Application.ViewModel
{
    public partial class CarListViewModel:BaseViewModel
    {
        private readonly CarServices _carServices;
        public ObservableCollection<Car> Cars { get; private set; } = new();


        public CarListViewModel(CarServices carServices)
        {
            Title = "Car List";
            _carServices = carServices;  
        }

        [RelayCommand]
        public async Task getCarList()
        {
            if(IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any())
                {
                    Cars.Clear();
                }
                /* else if (_isNotLoading)
                 {
                     var cars = _carServices.getCars();

                 }*/
                var cars = _carServices.getCars();
                foreach(var car in cars)
                {
                    Cars.Add(car);
                }

            }
            catch (Exception ex)
            {
                //Debug.WriteLine()
                await Shell.Current.DisplayAlert("Error", "Error Displaying List of Cars", "Cancel");
                throw;
            }
            finally
            {

            }
        }
    }
}
