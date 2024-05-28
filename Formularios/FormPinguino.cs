using Entidades;
using System;
using System.CodeDom;
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
                if (!double.TryParse(txtPeso.Text, out double peso) || peso <= 0)
                {
                    throw new ArgumentException("El peso debe ser un número mayor a 0.");
                }
                if (string.IsNullOrWhiteSpace(txtEspecie.Text))
                {
                    throw new ArgumentException("La especie no puede quedar vacía.");
                }


                string nombre = this.txtNombre.Text;
                Habitat habitat = (Habitat)this.cbHabitat.SelectedItem;
                string especie = this.txtEspecie.Text;

                Pinguino = new Pinguino(nombre, habitat, edad, peso, especie);

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
