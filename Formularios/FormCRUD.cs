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
        private Zoologico zoologico;
        public string ruta = "aves.xml";
        public FormCRUD()
        {
            InitializeComponent();
            zoologico = Zoologico.Deserializar(ruta);
            ActualizarLista();
        }

        private void FormCRUD_Load(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                if (File.Exists(ruta))
                {
                    try
                    {
                        zoologico = Zoologico.Deserializar(ruta);
                        ActualizarLista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    }
                }
                else
                {
                    zoologico = new Zoologico();
                }
            }
            else
            {
                zoologico.Aves = new List<Ave>();
            }
        }

        private void ActualizarLista()
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = zoologico.Aves;
            zoologico.Serializar(ruta);
        }

        private void btnPinguino_Click(object sender, EventArgs e)
        {
            FormPinguino form = new FormPinguino();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico.Aves.Add(form.Pinguino);
                this.ActualizarLista();
            }
        }

        private void btnColibri_Click(object sender, EventArgs e)
        {
            FormColibri form = new FormColibri();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico.Aves.Add(form.Colibri);
                this.ActualizarLista();
            }
        }

        private void btnHalcon_Click(object sender, EventArgs e)
        {
            FormHalcon form = new FormHalcon();
            if (form.ShowDialog() == DialogResult.OK)
            {
                zoologico.Aves.Add(form.Halcon);
                this.ActualizarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;
            if (indice != -1)
            {
                if (this.zoologico.Aves[indice] is Pinguino)
                {
                    FormPinguino form = new FormPinguino((Pinguino)this.zoologico.Aves[indice]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Pinguino;
                    }
                }
                else if (this.zoologico.Aves[indice] is Colibri)
                {
                    FormColibri form = new FormColibri((Colibri)this.zoologico.Aves[indice]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Colibri;
                    }
                }
                else
                {
                    FormHalcon form = new FormHalcon((Halcon)this.zoologico.Aves[indice]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.zoologico.Aves[indice] = form.Halcon;
                    }
                }

                this.ActualizarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;
            if (indice != -1)
            {
                this.zoologico.Aves.RemoveAt(indice);
                this.ActualizarLista();
            }
        }

        private void ordNombreAscendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorNombre(true);
            this.ActualizarLista();
        }

        private void ordNombreDescendente_Click(object sender, EventArgs e)
        {
            this.zoologico.OrdenarPorNombre(false);
            this.ActualizarLista();
        }
    }
}
