using System.Text;

namespace Entidades
{
    
    public abstract class Ave
    {
        public string nombre;
        public int edad;
        public Habitat habitat;

        public Ave(string nombre)
        {
            this.nombre = nombre;
        }

        public Ave(string nombre, Habitat habitat) 
            :this(nombre)
        {
            this.habitat = habitat;
        }

        public Ave(string nombre, Habitat habitat, int edad) 
            :this(nombre,habitat)
        {
            this.edad = edad;
        }

        public abstract void Volar();

        public virtual void Alimentarse()
        {
            Console.WriteLine($"{this.nombre} esta comiendo.");
        }

        public virtual void Alimentarse(string comida)
        {
            Console.WriteLine($"{this.nombre} esta comiendo un {comida}.");
        }

        public override string ToString()
        {
            return $"{this.nombre} \nEdad: {this.edad} \nHábitat: {this.habitat}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Ave)
            {
                Ave ave = (Ave)obj;
                return this.nombre == ave.nombre && this.edad == ave.edad && this.habitat == ave.habitat;
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
