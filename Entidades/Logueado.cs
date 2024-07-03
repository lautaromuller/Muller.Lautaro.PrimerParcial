using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Logueado
    {
        private const string usuarios = "usuarios.log";


        /// <summary>
        /// Guarda la información del usuario logueado en un archivo .log
        /// </summary>
        /// <param name="infoUsuario">información del usuario logueado</param>
        public static void Loguear(string dataUsuario)
        {
            try
            {
                string msj = $"{dataUsuario} \nFecha de acceso: {DateTime.Now}\n";

                List<string> lineas = new List<string>();
                if (File.Exists(usuarios))
                {
                    lineas = File.ReadAllLines(usuarios).ToList();
                }

                lineas.Insert(0, msj);

                File.WriteAllLines(usuarios, lineas);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
            }
        }
    }
}
