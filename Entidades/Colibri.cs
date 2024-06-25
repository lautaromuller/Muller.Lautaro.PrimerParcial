using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Colibri : Ave, IAccion<string>, ISerializable
    {
        public double VelocidadVuelo { get; set; }
        public string ColorPlumas { get; set; }

        #region Constructores

        public Colibri() { }
        public Colibri(string nombre, Habitat habitat, int edad, string colorPlumas, double velocidadVuelo)
            : base(nombre, habitat, edad)
        {
            this.ColorPlumas = colorPlumas;
            this.VelocidadVuelo = velocidadVuelo;
        }
        public Colibri(string nombre, Habitat habitat, int edad, string colorPlumas)
            : this(nombre, habitat, edad, colorPlumas, 0.0)
        {
            
        }
        public Colibri(string nombre, Habitat habitat, int edad)
            : this(nombre, habitat, edad,"", 0.0)
        {

        }

        #endregion

        #region Métodos
        /// <summary>
        /// Implementación del método abstracto Volar que muestra por consola como vuela el colibrí.
        /// </summary>
        public override string Volar()
        {
            return $"{this.Nombre} vuela a {this.VelocidadVuelo} km/h.";
        }

        public override string ToString()
        {
            return $"{base.ToString()}| Velocidad de vuelo: {this.VelocidadVuelo} | Color de plumas: {this.ColorPlumas}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Colibri)
            {
                Colibri ave = (Colibri)obj;
                return base.Equals(ave);
            }
            return false;
        }

        public string RealizarAccion(string accion)
        {
            return $"El colibrí {this.Nombre} esta {accion}";
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga del operador == para comprobar si dos Colibríes son iguales.
        /// </summary>
        /// <param name="h1">Primer colibrí a comparar</param>
        /// <param name="h2">Segundo colibrí a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator ==(Colibri c1, Colibri c2)
        {
            return c1.Equals(c2);
        }

        /// <summary>
        /// Sobrecarga del operador != para comprobar si dos Colibríes son distintos.
        /// </summary>
        /// <param name="h1">Primer colibrí a comparar</param>
        /// <param name="h2">Segundo colibrí a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator !=(Colibri c1, Colibri c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}
