using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAve
    {
        string Nombre { get; set; }
        Habitat Habitat { get; set; }
        int Edad { get; set; }

        void Volar();
        void Alimentarse();
        void Alimentarse(string comida);
    }
}
