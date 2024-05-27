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
    public partial class FormColibri : FormAve
    {
        public Colibri Colibri { get; set; }
        public FormColibri()
        {
            InitializeComponent();
        }

        public FormColibri(Colibri colibri)
            : this()
        {
            txtNombre.Text = colibri.Nombre;
            cbHabitat.SelectedItem = colibri.Habitat;
            txtEdad.Text = colibri.Edad.ToString();
            txtColorPlumas.Text = colibri.ColorPlumas.ToString();
            txtVelocidadVuelo.Text = colibri.VelocidadVuelo.ToString();
            Colibri = colibri;
        }

        /// <summary>
        /// Maneja el evento click del boton aceptar. Crea una instancia de Colibri con los datos ingresados
        /// y cierra el formulario.
        /// </summary>
        public override void btnAceptar_Click(object sender, EventArgs e)
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
    }
}
