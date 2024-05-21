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
    public partial class FormColibri : Form
    {
        public Colibri Colibri { get; set; }
        public FormColibri()
        {
            InitializeComponent();
            this.cbHabitat.DataSource = Enum.GetValues(typeof(Habitat));
        }

        public FormColibri(Colibri colibri)
            : this()
        {
            txtNombre.Text = colibri.nombre;
            cbHabitat.SelectedItem = colibri.habitat;
            txtEdad.Text = colibri.edad.ToString();
            txtColorPlumas.Text = colibri.colorPlumas.ToString();
            txtVelocidadVuelo.Text = colibri.velocidadVuelo.ToString();
            Colibri = colibri;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.txtNombre.Text;
                Habitat habitat = (Habitat)this.cbHabitat.SelectedItem;
                int edad = int.Parse(this.txtEdad.Text);
                string colorPlumas = this.txtColorPlumas.Text;
                double velocidadVuelo = double.Parse(this.txtVelocidadVuelo.Text);

                Colibri = new Colibri(nombre, habitat, edad, colorPlumas, velocidadVuelo);

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
