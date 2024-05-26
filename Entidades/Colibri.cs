using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Colibri : Ave
    {
        public double VelocidadVuelo { get; set; }
        public string ColorPlumas { get; set; }

        public Colibri() { }

        public Colibri(string nombre, Habitat habitat, int edad) 
            :base(nombre, habitat, edad) 
        { 

        }

        public Colibri(string nombre, Habitat habitat, int edad, string colorPlumas) 
            :this(nombre, habitat, edad)
        {
            this.ColorPlumas = colorPlumas;
        }

        public Colibri(string nombre, Habitat habitat, int edad, string colorPlumas, double velocidadVuelo)
            : this(nombre, habitat, edad, colorPlumas)
        {
            this.VelocidadVuelo = velocidadVuelo;
        }

        public override void Volar()
        {
            Console.WriteLine($"{this.Nombre} vuela a {this.VelocidadVuelo} km/h.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nVelocidad de Vuelo: {this.VelocidadVuelo} \nColor de Plumas: {this.ColorPlumas}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Colibri)
            {
                Colibri ave = (Colibri)obj;
                return base.Equals(ave) && this.Nombre == ave.Nombre && this.Edad == ave.Edad && this.Habitat == ave.Habitat;
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
