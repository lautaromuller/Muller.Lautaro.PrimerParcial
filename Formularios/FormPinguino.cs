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
    public partial class FormPinguino : Form
    {
        public Pinguino Pinguino { get; set; }
        public FormPinguino()
        {
            InitializeComponent();
            this.cbHabitat.DataSource = Enum.GetValues(typeof(Habitat));
        }

        public FormPinguino(Pinguino pinguino)
            :this()
        {
            txtNombre.Text = pinguino.nombre;
            cbHabitat.SelectedItem = pinguino.habitat;
            txtEdad.Text = pinguino.edad.ToString();
            txtPeso.Text = pinguino.peso.ToString();
            txtEspecie.Text = pinguino.especie;
            Pinguino = pinguino;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.txtNombre.Text;
                Habitat habitat = (Habitat)this.cbHabitat.SelectedItem;
                int edad = int.Parse(this.txtEdad.Text);
                double peso = double.Parse(this.txtPeso.Text);
                string especie = this.txtEspecie.Text;

                Pinguino = new Pinguino(nombre, habitat, edad, peso, especie);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
