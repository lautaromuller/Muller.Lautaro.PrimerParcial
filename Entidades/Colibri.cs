using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Colibri : Ave
    {
        public double velocidadVuelo;
        public string colorPlumas;

        public Colibri(string nombre, Habitat habitat, int edad) 
            :base(nombre, habitat, edad) 
        { 

        }

        public Colibri(string nombre, Habitat habitat, int edad, string colorPlumas) 
            :this(nombre, habitat, edad)
        {
            this.colorPlumas = colorPlumas;
        }

        public Colibri(string nombre, Habitat habitat, int edad, string colorPlumas, double velocidadVuelo)
            : this(nombre, habitat, edad, colorPlumas)
        {
            this.velocidadVuelo = velocidadVuelo;
        }

        public override void Volar()
        {
            Console.WriteLine($"{this.nombre} vuela a {this.velocidadVuelo} km/h.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nVelocidad de Vuelo: {this.velocidadVuelo} \nColor de Plumas: {this.colorPlumas}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Colibri)
            {
                Colibri ave = (Colibri)obj;
                return base.Equals(ave) && this.nombre == ave.nombre && this.edad == ave.edad && this.habitat == ave.habitat;
            }
            return false;
        }

        public static bool operator ==(Colibri c1, Colibri c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Colibri c1, Colibri c2)
        {
            return !(c1 == c2);
        }
    }
}
