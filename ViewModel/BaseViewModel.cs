using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Car_Listing_MAUI_Application.ViewModel
{
    public partial class BaseViewModel : ObservableObject
        //INotifyPropertyChanged
    {

        //fields
        [ObservableProperty]
        string _title;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(_isNotLoading))]
        bool _isLoading;

        
        public bool _isNotLoading => !_isLoading;

        //properties
        /*public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            { 
                if(_isBusy == value)
                {
                    return;
                }
                else
                {
                    _isBusy = value;
                    onPropertyChange();
                }
                
            }

        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title == value)
                {
                    return;
                }
                else
                {
                    _title = value;
                    onPropertyChange();
                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }*/
    }
}
