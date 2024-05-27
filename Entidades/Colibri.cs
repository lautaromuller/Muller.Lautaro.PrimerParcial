﻿using System;
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

        /// <summary>
        /// Implementación del método abstracto Volar que muestra por consola como vuela el colibrí.
        /// </summary>
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
                return base.Equals(ave);
            }
            return false;
        }

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
    }
}
