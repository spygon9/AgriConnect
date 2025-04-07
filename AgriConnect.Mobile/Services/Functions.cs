using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriConnect.Mobile.Interfaces;

namespace AgriConnect.Mobile.Services
{
    public class Functions : IFunctions
    {
        public string CambiarTexto(string texto, int count) => $"{texto} - {count}";
    }
}
