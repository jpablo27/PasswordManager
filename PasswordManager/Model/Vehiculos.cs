using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    public class Vehiculos
    {
        public Vehiculos()
        {
            this.NumeroDeSerie = "000000000X-YTTHOLA";
            this.Matricula = "XLS-1234-e";
            this.Ejes = 1;
            this.Llantas = 1;
            this.Motor = 1.5;

  
        }

        public string NumeroDeSerie { get; }

        public string Matricula { get; set; }

        public int Ejes { get; set; }

        public int Llantas { get; set; }

        public double Motor { get; set; }

        public override string ToString()
        {
            return $"Nombre: {this.GetType().Name}    Matricula: {this.Matricula}";
        }
    }
}
