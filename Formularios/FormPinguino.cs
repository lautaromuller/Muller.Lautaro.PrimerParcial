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
    public partial class FormPinguino : FormAve
    {
        public Pinguino Pinguino { get; set; }
        public FormPinguino()
        {
            InitializeComponent();
        }

        public FormPinguino(Pinguino pinguino)
            : this()
        {
            txtNombre.Text = pinguino.Nombre;
            cbHabitat.SelectedItem = pinguino.Habitat;
            txtEdad.Text = pinguino.Edad.ToString();
            txtPeso.Text = pinguino.Peso.ToString();
            txtEspecie.Text = pinguino.Especie;
            Pinguino = pinguino;
        }

        /// <summary>
        /// Maneja el evento click del boton aceptar. Crea una instancia de Pinguino con los datos ingresados
        /// y cierra el formulario.
        /// </summary>
        public override void btnAceptar_Click(object sender, EventArgs e)
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
    }
}
