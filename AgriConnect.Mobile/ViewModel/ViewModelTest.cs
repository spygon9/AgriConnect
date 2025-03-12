using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AgriConnect.Mobile.ViewModel
{
    partial class ViewModelTest: ObservableObject
    {
        [ObservableProperty]
        public string text;
        [ObservableProperty]
        int count;
        [RelayCommand]
        public void CambiarTexto()
        {
            Count++;
            Text ="Hola mundo";
        }
    }
}
