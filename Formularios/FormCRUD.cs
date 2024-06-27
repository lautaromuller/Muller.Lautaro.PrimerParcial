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
using System.Xml.Serialization;

namespace Formularios
{
    public partial class FormCRUD : Form
    {
        private string nombreUsuario;
        private Zoologico<Ave> zoologico;
        public string ruta = "aves.xml";
        private AveDAO aveDAO;
        public FormCRUD(string nombreUsuario)
        {
            InitializeComponent();
            zoologico = Zoologico<Ave>.Deserializar(ruta);
            ActualizarLista();
            this.nombreUsuario = nombreUsuario;
            this.lblStatusStrip.Text = $"{nombreUsuario} | {DateTime.Now.ToString("d")}";
            aveDAO = new AveDAO();
        }

        /// <summary>
        /// Manejador del evento load del formulario. Deserializa el zoológico del archivo de origen
        /// y inicializa la lista de aves.
        /// </summary>
        private void FormCRUD_Load(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                if (File.Exists(ruta))
                {
                    try
                    {
                        zoologico = Zoologico<Ave>.Deserializar(ruta);
                        ActualizarLista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    }
                }
                else
                {
                    zoologico = new Zoologico<Ave>();
                }
            }
            else
            {
                zoologico.Aves = new List<Ave>();
            }
        }

        /// <summary>
        /// Actualiza el listBox con la información de la lista de aves y llama a la función que Serializar.
        /// </summary>
        private void ActualizarLista()
        {
            this.listBox1.DataSource = null;
            if (this.rbDaseDatos.Checked)
            {
                this.listBox1.DataSource = aveDAO.Leer();
            }
            else
            {
                this.listBox1.DataSource = zoologico.Aves;
            }
        }

        /// <summary>
        /// Llama a FormPinguino para poder ingresar un nuevo pinguino.
        /// </summary>
        private void btnPinguino_Click(object sender, EventArgs e)
        {
            FormPinguino form = new FormPinguino();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico += form.Pinguino;
                if (this.rbDaseDatos.Checked)
                {
                    aveDAO.Guardar(form.Pinguino);
                }
                this.ActualizarLista();
            }
        }

        /// <summary>
        /// Llama a FormColibri para poder ingresar un nuevo colibrí.
        /// </summary>
        private void btnColibri_Click(object sender, EventArgs e)
        {
            FormColibri form = new FormColibri();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico += form.Colibri;
                if (this.rbDaseDatos.Checked)
                {
                    aveDAO.Guardar(form.Colibri);
                }
                this.ActualizarLista();
            }
        }

        /// <summary>
        /// Llama a FormHalcon para poder ingresar un nuevo halcón.
        /// </summary>
        private void btnHalcon_Click(object sender, EventArgs e)
        {
            FormHalcon form = new FormHalcon();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico += form.Halcon;
                if (this.rbDaseDatos.Checked)
                {
                    aveDAO.Guardar(form.Halcon);
                }
                this.ActualizarLista();
            }
        }

        /// <summary>
        /// Manejador de evento click del boton Modificar. LLama al formulario correspondiente al item seleccionado
        /// y lo inicializa con los valores actuales para poder modificarlo.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;
            if (indice != -1)
            {
                Ave aveSeleccionada = this.zoologico.Aves[indice];
                if (aveSeleccionada is Pinguino pinguino)
                {
                    FormPinguino form = new FormPinguino(pinguino);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Pinguino;

                        if (this.rbDaseDatos.Checked)
                        {
                            aveDAO.Modificar(aveSeleccionada, form.Pinguino);
                        }

                        this.ActualizarLista();
                    }
                }
                else if (aveSeleccionada is Colibri colibri)
                {
                    FormColibri form = new FormColibri(colibri);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Colibri;

                        if (this.rbDaseDatos.Checked)
                        {
                            aveDAO.Modificar(aveSeleccionada, form.Colibri);
                        }

                        this.ActualizarLista();
                    }
                }
                else if (aveSeleccionada is Halcon halcon)
                {
                    FormHalcon form = new FormHalcon(halcon);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Halcon;

                        if (this.rbDaseDatos.Checked)
                        {
                            aveDAO.Modificar(aveSeleccionada, form.Halcon);
                        }

                        this.ActualizarLista();
                    }
                }

                this.ActualizarLista();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Manejador de evento click del boton Eliminar. Elimina el item seleccionado.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;
            if (indice != -1)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro que desea eliminar este elemento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rta == DialogResult.Yes)
                {
                    Ave aveSeleccionada = this.zoologico.Aves[indice];

                    if (this.rbDaseDatos.Checked)
                    {
                        aveDAO.Eliminar(aveSeleccionada);
                    }
                    zoologico.Serializar(ruta);
                    zoologico -= aveSeleccionada;
                    this.ActualizarLista();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ordena la lista por nombre de forma ascendente.
        /// </summary>
        private void ordNombreAscendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorNombre(true);
            this.ActualizarLista();
        }

        /// <summary>
        /// Ordena la lista por nombre de forma descendente.
        /// </summary>
        private void ordNombreDescendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorNombre(false);
            this.ActualizarLista();
        }

        /// <summary>
        /// Ordena la lista por edad de forma ascendente.
        /// </summary>
        private void ordEdadAscendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorEdad(true);
            this.ActualizarLista();
        }

        /// <summary>
        /// Ordena la lista por edad de forma descendente.
        /// </summary>
        private void ordEdadDescendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorEdad(false);
            this.ActualizarLista();
        }

        /// <summary>
        /// Confirmar cierre de la aplicación
        /// </summary>
        private void FormCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                try
                {
                    zoologico.Serializar(ruta);
                    e.Cancel = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al serializar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (rta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Guardar archivo en una ubicación elegida por el usuario
        /// </summary>
        private void guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json",
                Title = "Guardar archivo"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = saveFileDialog.FileName;
                zoologico.Serializar(ruta);
            }
        }

        /// <summary>
        /// Abre formulario con el historial de usuarios que utilizaron la aplicación
        /// </summary>
        private void logins_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.ShowDialog();
        }

        /// <summary>
        /// Cargar un archivo xml con aves guardado en la computadora
        /// </summary>
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json",
                Title = "Cargar archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                zoologico = Zoologico<Ave>.Deserializar(ruta);
            }
            this.ActualizarLista();
        }

        /// <summary>
        /// Cargar información de la base de datos
        /// </summary>
        private void baseDeDatos_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox1.DataSource = aveDAO.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
