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
        public static void Loguear(string infoUsuario)
        {
            try
            {
                string msj = $"{infoUsuario} \nFecha de acceso: {DateTime.Now}\n";
                File.AppendAllText(usuarios, msj + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
            }
        }
    }
}
