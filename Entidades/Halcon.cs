using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Halcon : Ave
    {
        public double envergadura;
        public string rangoDeCaza;

        public Halcon(string nombre, Habitat habitat, int edad) 
            :base(nombre, habitat, edad)
        {

        }

        public Halcon(string nombre, Habitat habitat, int edad, double envergadura)
            :this(nombre, habitat, edad)
        {
            this.envergadura = envergadura;
        }

        public Halcon(string nombre, Habitat habitat, int edad, double envergadura, string rangoDeCaza)
            : this(nombre, habitat, edad,envergadura)
        {
            this.rangoDeCaza = rangoDeCaza;
        }

        public override void Volar()
        {
            Console.WriteLine($"{this.nombre} está volando con una envergadura de {this.envergadura} metros.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nEnvergadura: {this.envergadura} \nRango de Caza: {this.rangoDeCaza}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Halcon)
            {
                Halcon ave = (Halcon)obj;
                return base.Equals(obj) && this.envergadura == ave.envergadura && this.rangoDeCaza == ave.rangoDeCaza;
            }
            return false;
        }

        public static bool operator ==(Halcon h1, Halcon h2)
        {
            return h1.Equals(h2);
        }

        public static bool operator !=(Halcon h1, Halcon h2)
        {
            return !(h1 == h2);
        }
    }
}
