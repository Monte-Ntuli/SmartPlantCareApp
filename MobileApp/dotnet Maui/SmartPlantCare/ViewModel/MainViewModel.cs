using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using SmartPlantCare.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPlantCare.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _username;
        [ObservableProperty]
        private string _password;

        [ICommand]
        public async void Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
        }
    }
}
