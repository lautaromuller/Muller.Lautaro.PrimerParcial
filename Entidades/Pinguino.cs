using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    internal class Pinguino : Ave
    {
        public string tipo;
        public bool leGustaElFrio;
        public bool viveEnManada;

        public Pinguino(bool puedeVolar, string habitat, string sexo, string tipo) : base(puedeVolar, habitat, sexo)
        {
            this.tipo = tipo;
        }

        public Pinguino(bool puedeVolar, string habitat, string sexo, string tipo, bool leGustaElFrio) : this(puedeVolar, habitat, sexo, tipo)
        {
            this.leGustaElFrio = leGustaElFrio;
        }

        public Pinguino(bool puedeVolar, string habitat, string sexo, string tipo, bool leGustaElFrio, bool viveEnManada) : this(puedeVolar, habitat, sexo, tipo, leGustaElFrio)
        {
            this.viveEnManada = viveEnManada;
        }

        public override void Cazar()
        {
            Console.WriteLine("El Pingüino a cazado un pez");
        }
    }
}
