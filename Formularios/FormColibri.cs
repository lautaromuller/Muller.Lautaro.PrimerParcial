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
                if (string.IsNullOrWhiteSpace(txtColorPlumas.Text))
                {
                    throw new ArgumentException("El color de las plumas no puede quedar vacío.");
                }
                if (!double.TryParse(this.txtVelocidadVuelo.Text, out double velocidadVuelo) || velocidadVuelo <= 0)
                {
                    throw new ArgumentException("La velocidad de vuelo debe ser un número mayor a 0.");
                }


                string nombre = this.txtNombre.Text;
                Habitat habitat = (Habitat)this.cbHabitat.SelectedItem;
                string colorPlumas = this.txtColorPlumas.Text;

                Colibri = new Colibri(nombre, habitat, edad, colorPlumas, velocidadVuelo);

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
