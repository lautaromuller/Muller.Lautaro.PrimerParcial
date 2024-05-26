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
    public class Zoologico
    {
        public List<Ave> Aves { get; set; }

        public Zoologico()
        {
            this.Aves = new List<Ave>();
        }

        public void Serializar(string ruta)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Zoologico));
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

        public static Zoologico Deserializar(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Zoologico));
                    using (StreamReader reader = new StreamReader(ruta))
                    {
                        return (Zoologico)serializer.Deserialize(reader);
                    }
                }
                return new Zoologico();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                return new Zoologico();
            }
        }

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

        public string MostrarAves()
        {
            return string.Join(", ", Aves);
        }

        public static Zoologico operator +(Zoologico z, Ave a)
        {
            if (!z.Aves.Contains(a))
            {
                z.Aves.Add(a);
            }
            return z;
        }

        public static Zoologico operator -(Zoologico z, Ave a)
        {
            if (z.Aves.Contains(a))
            {
                z.Aves.Remove(a);
            }
            return z;
        }
    }
}
