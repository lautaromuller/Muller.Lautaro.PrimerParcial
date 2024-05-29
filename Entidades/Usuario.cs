using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    /// <summary>
    /// Clase que representa a un usuario
    /// </summary>
    public class Usuario
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string perfil { get; set; }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} {this.apellido} \nLegajo: {this.legajo} \nCorreo: {this.correo} \nClave: {this.clave} \nPerfil: {this.perfil}";
        }
    }
}
