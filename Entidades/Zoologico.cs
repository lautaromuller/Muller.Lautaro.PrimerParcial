using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Zoologico<T> where T : Ave, ISerializable
    {
        public List<T> Aves { get; set; }

        public Zoologico()
        {
            this.Aves = new List<T>();
        }

        #region Métodos


        /// <summary>
        /// Serializa el código a un archivo XML.
        /// </summary>
        /// <param name="ruta">Ruta donde se guardará el archivo</param>
        public void Serializar(string ruta)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Zoologico<T>));
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    serializer.Serialize(writer, this);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el archivo: {ex.Message}");
            }
        }

        /// <summary>
        /// Deserializa un zoológico desde un archivo XML.
        /// </summary>
        /// <param name="ruta">Ruta del archivo desde donde se descargara el zoológico</param>
        /// <returns>Instancia del zoológico deserializado</returns>
        public static Zoologico<T> Deserializar(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Zoologico<T>));
                    using (StreamReader reader = new StreamReader(ruta))
                    {
                        return (Zoologico<T>)serializer.Deserialize(reader);
                    }
                }
                return new Zoologico<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                return new Zoologico<T>();
            }
        }

        /// <summary>
        /// Ordena la lista de aves del zoológico por nombre.
        /// </summary>
        /// <param name="ascendente">Orden en el que se ordena. Por defecto: true</param>
        public void OrdenarPorNombre(bool ascendente = true)
        {
            if (ascendente)
            {
                Aves = Aves.OrderBy(a => a.Nombre).ToList();
            }
            else
            {
                Aves = Aves.OrderByDescending(a => a.Nombre).ToList();
            }
        }

        /// <summary>
        /// Ordena la lista de aves del zoológico por edad.
        /// </summary>
        /// <param name="ascendente">Orden en el que se ordena. Por defecto: true</param>
        public void OrdenarPorEdad(bool ascendente = true)
        {
            if (ascendente)
            {
                Aves = Aves.OrderBy(a => a.Edad).ToList();
            }
            else
            {
                Aves = Aves.OrderByDescending(a => a.Edad).ToList();
            }
        }
        
        
        #endregion

        #region Operadores


        /// <summary>
        /// Sobrecarga del operador + para agregar un ave al zoológico.
        /// </summary>
        /// <param name="z">Zoológico al que se va a agregar el ave</param>
        /// <param name="a">Ave que se va a agregar</param>
        /// <returns>El zoológico con el ave agregada</returns>
        public static Zoologico<T> operator +(Zoologico<T> z, T a)
        {
            if (!(z == a))
            {
                z.Aves.Add(a);
            }
            return z;
        }

        /// <summary>
        /// Sobrecarga del operador - para eliminar un ave al zoológico.
        /// </summary>
        /// <param name="z">Zoológico del que se va a eliminar el ave</param>
        /// <param name="a">Ave que se va a eliminar</param>
        /// <returns>El zoológico con el ave eliminada</returns>
        public static Zoologico<T> operator -(Zoologico<T> z, T a)
        {
            if (z == a)
            {
                z.Aves.Remove(a);
            }
            return z;
        }

        /// <summary>
        /// Sobrecarga del operador == para ver si el zoológico contiene un ave especifico.
        /// </summary>
        /// <param name="z">Zoológico que se va a revisar</param>
        /// <param name="a">Ave que se va a buscar</param>
        /// <returns>booleano</returns>
        public static bool operator ==(Zoologico<T> z, T a)
        {
            foreach (var item in z.Aves)
            {
                if(item == a)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador != para ver si el zoológico no contiene un ave especifico.
        /// </summary>
        /// <param name="z">Zoológico que se va a revisar</param>
        /// <param name="a">Ave que se va a buscar</param>
        /// <returns>booleano</returns>
        public static bool operator !=(Zoologico<T> z, T a)
        {
            return !(z == a);
        }
        
        
        #endregion
    }
}
