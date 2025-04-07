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
        private readonly IFunctions functions;
        [ObservableProperty]
        string text;
        [ObservableProperty]
        int count;
        public ViewModelTest() => this.functions = App.Current.Services.GetRequiredService<IFunctions>();
        [RelayCommand]
        public void CambiarTexto()
        {
            Count++;
            Text = functions.CambiarTexto("Hola mundo", Count);
        }
    }
}
