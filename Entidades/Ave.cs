namespace Entidades
{
    public abstract class Ave
    {
        private bool puedeVolar;
        private string habitat;
        private string sexo;

        public Ave(bool puedeVolar) //Sobrecarga a elección
        {
            this.puedeVolar = puedeVolar;
        }

        public Ave(bool puedeVolar, string habitat) : this(puedeVolar)  //Sobrecarga con un parámetro menos
        {
            this.habitat = habitat;
        }

        public Ave(bool puedeVolar, string habitat, string sexo) : this(puedeVolar, habitat) //Sobrecarga con todos los parámetros
        {
            this.sexo = sexo;
        }

        public abstract void Cazar();

        public virtual void MetodoVirtual()
        {
            //Metodo virtual
        }


    }
}
