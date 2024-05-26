using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Halcon : Ave
    {
        public double Envergadura { get; set; }
        public string RangoDeCaza { get; set; }

        public Halcon() { }
        public Halcon(string nombre, Habitat habitat, int edad) 
            :base(nombre, habitat, edad)
        {

        }

        public Halcon(string nombre, Habitat habitat, int edad, double envergadura)
            :this(nombre, habitat, edad)
        {
            this.Envergadura = envergadura;
        }

        public Halcon(string nombre, Habitat habitat, int edad, double envergadura, string rangoDeCaza)
            : this(nombre, habitat, edad,envergadura)
        {
            this.RangoDeCaza = rangoDeCaza;
        }

        public override void Volar()
        {
            Console.WriteLine($"{this.Nombre} está volando con una envergadura de {this.Envergadura} metros.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nEnvergadura: {this.Envergadura} \nRango de Caza: {this.RangoDeCaza}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Halcon)
            {
                Halcon ave = (Halcon)obj;
                return base.Equals(obj) && this.Envergadura == ave.Envergadura && this.RangoDeCaza == ave.RangoDeCaza;
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
