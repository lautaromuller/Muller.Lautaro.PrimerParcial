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

        /// <summary>
        /// Maneja el evento click del boton aceptar. Crea una instancia de Halcon con los datos ingresados
        /// y cierra el formulario.
        /// </summary>
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

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new ArgumentException("El nombre no puede quedar vacío.");
                }
                if (cbHabitat.SelectedItem == null)
                {
                    throw new ArgumentException("Debe seleccionar un hábitat.");
                }
                if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0)
                {
                    throw new ArgumentException("La edad debe ser un número entero mayor o igual a 0.");
                }
                if (!double.TryParse(this.txtEnvergadura.Text, out double envergadura) || envergadura <= 0)
                {
                    throw new ArgumentException("La envergadura debe ser un número mayor a 0.");
                }
                if (string.IsNullOrWhiteSpace(txtRangoCaza.Text))
                {
                    throw new ArgumentException("El rango de caza no puede quedar vacío.");
                }


                string nombre = this.txtNombre.Text;
                Habitat habitat = (Habitat)this.cbHabitat.SelectedItem;
                string rangoDeCaza = this.txtRangoCaza.Text;

                Halcon = new Halcon(nombre, habitat, edad, envergadura, rangoDeCaza);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
