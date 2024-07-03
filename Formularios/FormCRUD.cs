using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Formularios
{
    public partial class FormCRUD : Form
    {
        #region Atributos

        private Usuario usuario;
        public string ruta = "aves.xml";
        private AveDAO aveDAO;
        private Zoologico<Ave> zoologico;

        #endregion


        public delegate void OrdenamientoHandler(OrdenamientoArgs e);
        public event OrdenamientoHandler Ordenado;


        #region Constructor


        public FormCRUD(Usuario nuevoUsuario)
        {
            InitializeComponent();
            this.usuario = nuevoUsuario;
            aveDAO = new AveDAO();
            aveDAO.OperacionCompleta += OperacionCompleta;

            if (!File.Exists(ruta)) { zoologico = new Zoologico<Ave>(); }
            zoologico = Zoologico<Ave>.Deserializar(ruta);

            this.lblStatusStrip.Text = $"{this.usuario.nombre} {this.usuario.apellido} | {DateTime.Now.ToString("d")}";

            Ordenado += Ordenamiento;
            ConfigurarPermisos(this.usuario.perfil);

            ActualizarLista();
        }


        #endregion



        #region Métodos

        private void ConfigurarPermisos(string perfil)
        {
            if (perfil == "administrador")
            {
                HabilitarPermisos(true, true, true);
            }
            else if (perfil == "supervisor")
            {
                HabilitarPermisos(true, true, false);
            }
            else if (perfil == "vendedor")
            {
                HabilitarPermisos(false, false, false);
            }
        }

        private void HabilitarPermisos(bool create, bool update, bool delete)
        {
            this.btnPinguino.Enabled = create;
            this.btnHalcon.Enabled = create;
            this.btnColibri.Enabled = create;
            this.btnModificar.Enabled = update;
            this.btnEliminar.Enabled = delete;

            if (create == false)
            {
                this.btnPinguino.Text = "NO TIENE PERMISOS";
                this.btnColibri.Text = "NO TIENE PERMISOS";
                this.btnHalcon.Text = "NO TIENE PERMISOS";
            }
            if (update == false)
            {
                this.btnModificar.Text = "NO TIENE PERMISOS";
            }
            if (delete == false)
            {
                this.btnEliminar.Text = "NO TIENE PERMISOS";
            }

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
        private void btnPinguino_Click(object sender, EventArgs e)
        {
            FormPinguino form = new FormPinguino();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico += form.Pinguino;
                Task.Run(() =>
                {
                    try
                    {
                        aveDAO.Guardar(form.Pinguino);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar pinguino: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
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
                Task.Run(() =>
                {
                    try
                    {
                        aveDAO.Guardar(form.Colibri);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar colibrí: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
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
                Task.Run(() =>
                {
                    try
                    {
                        aveDAO.Guardar(form.Halcon);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar halcon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }




        /// <summary>
        /// Manejador de evento click del boton Modificar. LLama al formulario correspondiente al item seleccionado
        /// y lo inicializa con los valores actuales para poder modificarlo.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
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
                        Task.Run(() =>
                        {
                            try
                            {
                                aveDAO.Modificar(aveSeleccionada, form.Pinguino);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al modificar ave: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        });
                    }
                }
                else if (aveSeleccionada is Colibri colibri)
                {
                    FormColibri form = new FormColibri(colibri);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Colibri;
                        Task.Run(() =>
                        {
                            try
                            {
                                aveDAO.Modificar(aveSeleccionada, form.Colibri);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al modificar ave: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        });
                    }
                }
                else if (aveSeleccionada is Halcon halcon)
                {
                    FormHalcon form = new FormHalcon(halcon);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Halcon;
                        Task.Run(() =>
                        {
                            try
                            {
                                aveDAO.Modificar(aveSeleccionada, form.Halcon);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al modificar ave: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        });
                    }
                }
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
            if (indice >= 0 && indice < this.zoologico.Aves.Count)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro que desea eliminar este elemento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Ave aveSeleccionada = this.zoologico.Aves[indice];
                if (rta == DialogResult.Yes)
                {
                    zoologico -= aveSeleccionada;
                    Task.Run(() =>
                    {
                        try
                        {
                            aveDAO.Eliminar(aveSeleccionada.Id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el ave: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });

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
            OnOrdenado("Nombre (ascendente)");
        }

        /// <summary>
        /// Ordena la lista por nombre de forma descendente.
        /// </summary>
        private void ordNombreDescendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorNombre(false);
            this.ActualizarLista();
            OnOrdenado("Nombre (descendente)");
        }

        /// <summary>
        /// Ordena la lista por edad de forma ascendente.
        /// </summary>
        private void ordEdadAscendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorEdad(true);
            this.ActualizarLista();
            OnOrdenado("Edad (ascendente)");
        }

        /// <summary>
        /// Ordena la lista por edad de forma descendente.
        /// </summary>
        private void ordEdadDescendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorEdad(false);
            this.ActualizarLista();
            OnOrdenado("Edad (descendente)");
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
        /// Escucha del evento de ordenamiento del listbox. Invoca a la función del evento ordenado
        /// </summary>
        /// <param name="criterio">Criterio de ordenamiento</param>
        private void OnOrdenado(string criterio)
        {
            Ordenado?.Invoke(new OrdenamientoArgs(criterio));
        }

        /// <summary>
        /// Función del evento Ordenado. Crea un messageBox indicando el criterio de ordenamiento.
        /// </summary>
        /// <param name="e">Clase que contiene el criterio de ordenamiento</param>
        private void Ordenamiento(OrdenamientoArgs e)
        {
            this.lblOrden.Text = "Orden: " + e.Criterio;
        }

        /// <summary>
        /// Función del evento OperacionCompleta. Invoca a la función ActualizarLista
        /// </summary>
        private void OperacionCompleta(object sender, EventArgs e)
        {
            this.Invoke(() => ActualizarLista());
        }



        #endregion


    }
}
