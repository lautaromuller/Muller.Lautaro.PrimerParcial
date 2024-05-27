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

        /// <summary>
        /// Implementación del método abstracto Volar que muestra por consola como vuela el Halcón.
        /// </summary>
        public override void Volar()
        {
            Console.WriteLine($"{this.Nombre} está volando con una envergadura de {this.Envergadura} metros.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Envergadura: {this.Envergadura} - Rango de Caza: {this.RangoDeCaza}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Halcon)
            {
                Halcon ave = (Halcon)obj;
                return base.Equals(obj) && this.Envergadura == ave.Envergadura;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador == para comprobar si dos halcones son iguales.
        /// </summary>
        /// <param name="h1">Primer halcón a comparar</param>
        /// <param name="h2">Segundo halcón a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator ==(Halcon h1, Halcon h2)
        {
            return h1.Equals(h2);
        }

        /// <summary>
        /// Sobrecarga del operador == para comprobar si dos halcones son distintos.
        /// </summary>
        /// <param name="h1">Primer halcón a comparar</param>
        /// <param name="h2">Segundo halcón a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator !=(Halcon h1, Halcon h2)
        {
            return !(h1 == h2);
        }
    }
}
