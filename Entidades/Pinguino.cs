using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pinguino : Ave
    {
        public double peso;
        public string especie;

        public Pinguino(string nombre, Habitat habitat, int edad) 
            :base(nombre, habitat, edad)
        {

        }

        public Pinguino(string nombre, Habitat habitat, int edad, double peso)
            :this(nombre, habitat, edad)
        {
            this.peso = peso;
        }

        public Pinguino(string nombre, Habitat habitat, int edad, double peso, string especie)
            :this(nombre, habitat, edad, peso)
        {
            this.especie = especie;
        }

        public override void Volar()
        {
            Console.WriteLine($"{this.nombre} no puede volar.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nPeso: {this.peso} \nEspecie: {this.especie}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Pinguino)
            {
                Pinguino ave = (Pinguino)obj;
                return base.Equals(ave) && this.nombre == ave.nombre && this.edad == ave.edad && this.habitat == ave.habitat;
            }
            return false;
        }

        public static bool operator ==(Pinguino p1, Pinguino p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Pinguino p1, Pinguino p2)
        {
            return !(p1 == p2);
        }
    }
}
