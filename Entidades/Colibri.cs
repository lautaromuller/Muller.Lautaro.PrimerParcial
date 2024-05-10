using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Flores { Salvia, Girasol, Alamo, Heliconias, Geranios, Hibisco }
    internal class Colibri : Ave
    {
        public Flores florPreferida;
        public bool haceMigracion;

        public Colibri(bool puedeVolar, string habitat, string sexo) : base(puedeVolar, habitat, sexo) { }

        public Colibri(bool puedeVolar, string habitat, string sexo, Flores florPreferida) : this(puedeVolar, habitat, sexo) 
        {
            this.florPreferida = florPreferida;
        }

        public Colibri(bool puedeVolar, string habitat, string sexo, Flores florPreferida, bool haceMigracion) : this(puedeVolar, habitat, sexo, florPreferida) 
        { 
            this.haceMigracion = haceMigracion;
        }

        public override void Cazar()
        {
            Console.WriteLine("El Colibrí a cazado una araña");
        }
    }
}
