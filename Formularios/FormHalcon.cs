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
    public partial class FormHalcon : FormAve
    {
        public Halcon Halcon { get; set; }
        public FormHalcon()
        {
            InitializeComponent();
        }

        public FormHalcon(Halcon halcon)
            :this()
        {
            txtNombre.Text = halcon.Nombre;
            cbHabitat.SelectedItem = halcon.Habitat;
            txtEdad.Text = halcon.Edad.ToString();
            txtEnvergadura.Text = halcon.Envergadura.ToString();
            txtRangoCaza.Text = halcon.RangoDeCaza;
            Halcon = halcon;
        }

        /// <summary>
        /// Maneja el evento click del boton aceptar. Crea una instancia de Halcon con los datos ingresados
        /// y cierra el formulario.
        /// </summary>
        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.txtNombre.Text;
                Habitat habitat = (Habitat)this.cbHabitat.SelectedItem;
                int edad = int.Parse(this.txtEdad.Text);
                double envergadura = double.Parse(this.txtEnvergadura.Text);
                string rangoDeCaza = this.txtRangoCaza.Text;

                Halcon = new Halcon(nombre, habitat, edad, envergadura, rangoDeCaza);

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
