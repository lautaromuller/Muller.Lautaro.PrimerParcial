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
        public string ruta = "aves.xml";
        private AveDAO aveDAO;
        private Zoologico<Ave> zoologico;

        public delegate void OrdenamientoHandler(OrdenamientoArgs e);
        public event OrdenamientoHandler Ordenado;

        public FormCRUD(string nombreUsuario)
        {
            InitializeComponent();
            aveDAO = new AveDAO();
            if (!File.Exists(ruta))
            {
                zoologico = new Zoologico<Ave>();
            }
            zoologico = Zoologico<Ave>.Deserializar(ruta);
            ActualizarLista();
            this.lblStatusStrip.Text = $"{nombreUsuario} | {DateTime.Now.ToString("d")}";
            Ordenado += Ordenamiento;
        }

        /// <summary>
        /// Manejador del evento load del formulario. Deserializa el zoológico del archivo de origen
        /// y inicializa la lista de aves.
        /// </summary>
        private void FormCRUD_Load(object sender, EventArgs e)
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
        }

        /// <summary>
        /// Actualiza el listBox con la información de la lista de aves y llama a la función que Serializar.
        /// </summary>
        private void ActualizarLista()
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = zoologico.Aves;
            zoologico.Serializar(ruta);
        }



        /// <summary>
        /// Llama a FormPinguino para poder ingresar un nuevo pinguino.
        /// </summary>
        private async void btnPinguino_Click(object sender, EventArgs e)
        {
            FormPinguino form = new FormPinguino();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico += form.Pinguino;

                await aveDAO.GuardarAsync(form.Pinguino, async (command) => { await command.ExecuteNonQueryAsync(); return 1; });

                this.ActualizarLista();
            }
        }

        /// <summary>
        /// Llama a FormColibri para poder ingresar un nuevo colibrí.
        /// </summary>
        private async void btnColibri_Click(object sender, EventArgs e)
        {
            FormColibri form = new FormColibri();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico += form.Colibri;
                await aveDAO.GuardarAsync(form.Colibri, async (command) => { await command.ExecuteNonQueryAsync(); return 1; });
                
                this.ActualizarLista();
            }
        }

        /// <summary>
        /// Llama a FormHalcon para poder ingresar un nuevo halcón.
        /// </summary>
        private async void btnHalcon_Click(object sender, EventArgs e)
        {
            FormHalcon form = new FormHalcon();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico += form.Halcon;
                await aveDAO.GuardarAsync(form.Halcon, async (command) => { await command.ExecuteNonQueryAsync(); return 1; });
                
                this.ActualizarLista();
            }
        }



        /// <summary>
        /// Manejador de evento click del boton Modificar. LLama al formulario correspondiente al item seleccionado
        /// y lo inicializa con los valores actuales para poder modificarlo.
        /// </summary>
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;
            if (indice >= 0 && indice < this.zoologico.Aves.Count)
            {
                Ave aveSeleccionada = this.zoologico.Aves[indice];
                if (aveSeleccionada is Pinguino pinguino)
                {
                    FormPinguino form = new FormPinguino(pinguino);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Pinguino;

                        await aveDAO.ModificarAsync(aveSeleccionada, form.Pinguino, async (command) => { await command.ExecuteNonQueryAsync(); return 1; });
                        
                        this.ActualizarLista();
                    }
                }
                else if (aveSeleccionada is Colibri colibri)
                {
                    FormColibri form = new FormColibri(colibri);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Colibri;

                        await aveDAO.ModificarAsync(aveSeleccionada, form.Colibri, async (command) => { await command.ExecuteNonQueryAsync(); return 1; });
                        
                        this.ActualizarLista();
                    }
                }
                else if (aveSeleccionada is Halcon halcon)
                {
                    FormHalcon form = new FormHalcon(halcon);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Halcon;

                        await aveDAO.ModificarAsync(aveSeleccionada, form.Halcon, async (command) => { await command.ExecuteNonQueryAsync(); return 1; });
                        
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
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;
            if (indice >= 0 && indice < this.zoologico.Aves.Count)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro que desea eliminar este elemento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                Ave aveSeleccionada = this.zoologico.Aves[indice];
                if (rta == DialogResult.Yes)
                {
                    await aveDAO.EliminarAsync(aveSeleccionada.Id, async(command) => { await command.ExecuteNonQueryAsync(); return 1; });
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
            OnOrdenado("nombre en orden ascendente");
        }

        /// <summary>
        /// Ordena la lista por nombre de forma descendente.
        /// </summary>
        private void ordNombreDescendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorNombre(false);
            this.ActualizarLista();
            OnOrdenado("nombre en orden descendente");
        }

        /// <summary>
        /// Ordena la lista por edad de forma ascendente.
        /// </summary>
        private void ordEdadAscendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorEdad(true);
            this.ActualizarLista();
            OnOrdenado("edad en orden ascendente");
        }

        /// <summary>
        /// Ordena la lista por edad de forma descendente.
        /// </summary>
        private void ordEdadDescendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorEdad(false);
            this.ActualizarLista();
            OnOrdenado("nombre en orden descendente");
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
        /// Abre formulario con el historial de usuarios que utilizaron la aplicación
        /// </summary>
        private void logins_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.ShowDialog();
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
                zoologico.Aves = aveDAO.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarLista();
        }

        /// <summary>
        /// Escucha del evento de ordenamiento del listbox. Invoca a la función del evento
        /// </summary>
        /// <param name="criterio">Criterio de ordenamiento</param>
        protected virtual void OnOrdenado(string criterio)
        {
            Ordenado?.Invoke(new OrdenamientoArgs(criterio));
        }

        /// <summary>
        /// Función del evento Ordenado. Crea un messageBox indicando el criterio de ordenamiento.
        /// </summary>
        /// <param name="e">Clase que contiene el criterio de ordenamiento</param>
        private void Ordenamiento(OrdenamientoArgs e)
        {
            MessageBox.Show($"Lista ordenada por {e.Criterio}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
