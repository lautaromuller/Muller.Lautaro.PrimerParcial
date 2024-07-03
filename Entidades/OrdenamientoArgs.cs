using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OrdenamientoArgs : EventArgs
    {
        public string Criterio { get; set; }

        public OrdenamientoArgs(string criterio)
        {
            this.Criterio = criterio;
        }
    }
}
