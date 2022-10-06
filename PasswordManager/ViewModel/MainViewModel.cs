using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.ColleccionDeVehiculos = new List<Vehiculos>();

            var miauto = new Auto();
            var mibici = new Bici();
            var miavion = new Avion();

            this.ColleccionDeVehiculos.Add(miauto);
            this.ColleccionDeVehiculos.Add(mibici);
            this.ColleccionDeVehiculos.Add(miavion);
        }

        public List<Vehiculos> ColleccionDeVehiculos { get; set; }
    }
}
