using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Halcon : Ave
    {
        public int largoAlas;
        public string colorPlumaje;

        public Halcon(bool puedeVolar, string habitat, string sexo) : base(puedeVolar, habitat, sexo) { }

        public Halcon(bool puedeVolar, string habitat, string sexo, int largoAlas) : this(puedeVolar, habitat, sexo)
        {
            this.largoAlas = largoAlas;
        }

        public Halcon(bool puedeVolar, string habitat, string sexo, int largoAlas, string colorPlumaje) : this(puedeVolar, habitat, sexo, largoAlas)
        {
            this.colorPlumaje = colorPlumaje;
        }

        public override void Cazar()
        {
            Console.WriteLine("El Halcón a cazo una paloma");
        }
    }
}
