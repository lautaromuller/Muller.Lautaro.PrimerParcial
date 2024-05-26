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

        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
