using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AgriConnect.Mobile.ViewModel
{
    public partial class ColaboradoresViewModel: ObservableObject
    {
        public ObservableCollection<ColaboradoresModels> Colaboradores { get; set; } = new();
        [RelayCommand]
        public async Task ListarColaboradores()
        {
            Colaboradores.Clear();
            Colaboradores.Add(new ColaboradoresModels()
            {
                Nombre = "Brad",
                Apellidos = "Pitt"
            });
            Colaboradores.Add(new ColaboradoresModels()
            {
                Nombre = "Tom",
                Apellidos = "Cruise"
            });
            Colaboradores.Add(new ColaboradoresModels()
            {
                Nombre = "Angelina",
                Apellidos = "Jolie"
            });
            Colaboradores.Add(new ColaboradoresModels()
            {
                Nombre = "Jennifer",
                Apellidos = "López"
            });
            Colaboradores.Add(new ColaboradoresModels()
            {
                Nombre = "John",
                Apellidos = "Doe"
            });
            Colaboradores.Add(new ColaboradoresModels()
            {
                Nombre = "Jane",
                Apellidos = "Doe"
            });
            Colaboradores.Add(new ColaboradoresModels()
            {
                Nombre = "Tobey",
                Apellidos = "Maguire"
            });
        }
    }
}
