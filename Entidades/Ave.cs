﻿using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Pinguino))]
    [XmlInclude(typeof(Halcon))]
    [XmlInclude(typeof(Colibri))]
    public abstract class Ave : IAve, ISerializable
    {

        #region Propiedades

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Habitat Habitat { get; set; }


        #endregion

        #region Constructores
        public Ave(){}

        public Ave(string nombre)
        {
            this.Nombre = nombre;
        }

        public Ave(string nombre, Habitat habitat) 
            :this(nombre)
        {
            this.Habitat = habitat;
        }

        public Ave(string nombre, Habitat habitat, int edad) 
            :this(nombre,habitat)
        {
            this.Edad = edad;
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método abstracto que debera ser implementado por las clases derivadas para indicar el vuelo del ave.
        /// </summary>
        public abstract string Volar();

        /// <summary>
        /// Muestra por consola un mensaje indicando que el ave está comiendo.
        /// </summary>
        public virtual string Alimentarse()
        {
            return $"{this.Nombre} esta comiendo.";
        }

        /// <summary>
        /// Sobrecarga del método Alimertarse que permite pasarle un comida especifica.
        /// </summary>
        /// <param name="comida">Indica la comida del ave</param>
        public virtual string Alimentarse(string comida)
        {
            return $"{this.Nombre} esta comiendo un/a {comida}.";
        }

        public override string ToString()
        {
            return $"{this.Nombre} - Edad: {this.Edad} años - Hábitat: {this.Habitat}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Ave)
            {
                Ave ave = (Ave)obj;
                return this.Nombre == ave.Nombre && this.Edad == ave.Edad && this.Habitat == ave.Habitat;
            }
            return false;
        }

        public void Serializar(string ruta)
        {
            throw new NotImplementedException();
        }

        public void Deserializar(string ruta)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga del operador == que comprueba si las aves son iguales.
        /// </summary>
        /// <param name="a1">Primer ave a comparar</param>
        /// <param name="a2">Segundo ave a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator ==(Ave a1, Ave a2)
        {
            return a1.Equals(a2);
        }

        /// <summary>
        /// Sobrecarga del operador != que comprueba si las aves son distintas.
        /// </summary>
        /// <param name="a1">Primer ave a comparar</param>
        /// <param name="a2">Segundo ave a comparar</param>
        /// <returns>Booleano</returns>
        public static bool operator !=(Ave a1, Ave a2)
        {
            return !(a1 == a2);
        }

        #endregion
    }
}
