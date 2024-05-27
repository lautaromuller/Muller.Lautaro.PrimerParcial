using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormAve : Form
    {
        protected ComboBox cbHabitat;
        protected TextBox txtNombre;
        protected TextBox txtEdad;
        public FormAve()
        {
            InitializeComponent();
            this.cbHabitat.DataSource = Enum.GetValues(typeof(Habitat));
        }

        /// <summary>
        /// Maneja el evento click del boton aceptar. Método virtual que debe ser sobreescrito
        /// por las clases derivadas para definir su comportamiento.
        /// </summary>
        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento click del boton cancelar. Cambia el valor del dialogo a cancel y cierra
        /// el formulario.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
