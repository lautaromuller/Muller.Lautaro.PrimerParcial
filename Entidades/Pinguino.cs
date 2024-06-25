using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pinguino : Ave, IAccion<string>
    {
        public double Peso { get; set; }
        public string Especie { get; set; }

        #region Constructores
        public Pinguino() { }
        public Pinguino(string nombre, Habitat habitat, int edad, double peso, string especie)
            : base(nombre, habitat, edad)
        {
            this.Peso = peso;
            this.Especie = especie;
        }
        public Pinguino(string nombre, Habitat habitat, int edad, double peso)
            : this(nombre, habitat, edad, peso, "")
        {
        }
        public Pinguino(string nombre, Habitat habitat, int edad)
            : this(nombre, habitat, edad, 1.0, "")
        {
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Implementación del método abstracto Volar que muestra por consola como vuela el Pinguino.
        /// </summary>
        public override void Volar()
        {
            Console.WriteLine($"{this.Nombre} no puede volar.");
        }

        /// <summary>
        /// Muestra por consola qun mensaje indicando que el pinguino está jugando.
        /// </summary>
        public void Jugar()
        {
            Console.WriteLine($"{this.Nombre} está jugando.");
        }

        /// <summary>
        /// Sobrecarga del método Jugar que permite pasar un segundo pinguino como compañero de juego.
        /// </summary>
        /// <param name="otroPinguino">Nombre del segundo pinguino</param>
        public void Jugar(string otroPinguino)
        {
            Console.WriteLine($"{this.Nombre} y {otroPinguino} están jugando.");
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}| Peso: {this.Peso} | Especie: {this.Especie}";
        }

        
        public override bool Equals(object obj)
        {
            if (obj is Pinguino)
            {
                Pinguino ave = (Pinguino)obj;
                return base.Equals(ave) && this.Peso == ave.Peso && this.Especie == ave.Especie;
            }
            return false;
        }
        public void RealizarAccion(string accion)
        {
            Console.WriteLine($"El pinguino {this.Nombre} esta {accion}");
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga del operador == que comprueba si dos pinguinos son iguales.
        /// </summary>
        /// <param name="p1">Primer pinguino a comparar</param>
        /// <param name="p2">Segundo pinguino a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator ==(Pinguino p1, Pinguino p2)
        {
            return p1.Equals(p2);
        }

        /// <summary>
        /// Sobrecarga del operador != para coprobar si dos pinguinos son distintos.
        /// </summary>
        /// <param name="p1">Primer pinguino a comparar</param>
        /// <param name="p2">Segundo pinguino a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator !=(Pinguino p1, Pinguino p2)
        {
            return !(p1 == p2);
        }

        #endregion
    }
}
