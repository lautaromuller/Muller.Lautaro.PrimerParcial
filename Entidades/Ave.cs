using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Pinguino))]
    [XmlInclude(typeof(Halcon))]
    [XmlInclude(typeof(Colibri))]
    public abstract class Ave
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Habitat Habitat { get; set; }

        public Ave()
        {

        }

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

        public abstract void Volar();

        public virtual void Alimentarse()
        {
            Console.WriteLine($"{this.Nombre} esta comiendo.");
        }

        public virtual void Alimentarse(string comida)
        {
            Console.WriteLine($"{this.Nombre} esta comiendo un/a {comida}.");
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} - Hábitat: {this.Habitat} - Edad: {this.Edad}";
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

        public static bool operator ==(Ave a1, Ave a2)
        {
            return a1.Equals(a2);
        }

        public static bool operator !=(Ave a1, Ave a2)
        {
            return !(a1 == a2);
        }

    }
}
