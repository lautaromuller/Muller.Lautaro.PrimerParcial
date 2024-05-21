using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Zoologico
    {
        public List<Ave> aves;

        public Zoologico()
        {
            this.aves = new List<Ave>();
        }

        public static Zoologico operator +(Zoologico z, Ave a)
        {
            if (!z.aves.Contains(a))
            {
                z.aves.Add(a);
            }
            return z;
        }

        public static Zoologico operator -(Zoologico z, Ave a)
        {
            if (z.aves.Contains(a))
            {
                z.aves.Remove(a);
            }
            return z;
        }

        public void OrdenarPorNombre(bool ascendente)
        {
            if (ascendente)
            {
                aves = aves.OrderBy(a => a.nombre).ToList();
            }
            else
            {
                aves = aves.OrderByDescending(a => a.nombre).ToList();
            }
        }

        public void OrdenarPorEdad(bool ascendente)
        {
            if (ascendente)
            {
                aves = aves.OrderBy(a => a.edad).ToList();
            }
            else
            {
                aves = aves.OrderByDescending(a => a.edad).ToList();
            }
        }

        public void MostrarAves()
        {
            foreach (Ave ave in aves)
            {
                Console.WriteLine(ave + "\n");
            }
        }
    }
}
