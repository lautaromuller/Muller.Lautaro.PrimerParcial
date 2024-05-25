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
    public partial class FormCRUD : Form
    {
        public List<Ave> aves;
        public FormCRUD()
        {
            InitializeComponent();
            this.aves = new List<Ave>();
        }

        private void ActualizarLista()
        {
            this.listBox1.Items.Clear();
            foreach (var item in this.aves)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }

        private void btnPinguino_Click(object sender, EventArgs e)
        {
            FormPinguino form = new FormPinguino();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.aves.Add(form.Pinguino);
                this.ActualizarLista();
            }
        }

        private void btnColibri_Click(object sender, EventArgs e)
        {
            FormColibri form = new FormColibri();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.aves.Add(form.Colibri);
                this.ActualizarLista();
            }
        }

        private void btnHalcon_Click(object sender, EventArgs e)
        {
            FormHalcon form = new FormHalcon();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.aves.Add(form.Halcon);
                this.ActualizarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int indice = this.listBox1.SelectedIndex;
            if (indice != -1)
            {
                if (this.aves[indice] is Pinguino)
                {
                    FormPinguino form = new FormPinguino((Pinguino)this.aves[indice]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.aves[indice] = form.Pinguino;
                    }
                }
                else if (this.aves[indice] is Colibri)
                {
                    FormColibri form = new FormColibri((Colibri)this.aves[indice]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.aves[indice] = form.Colibri;
                    }
                }
                else
                {
                    FormHalcon form = new FormHalcon((Halcon)this.aves[indice]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.aves[indice] = form.Halcon;
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
                this.aves.RemoveAt(indice);
                this.ActualizarLista();
            }
        }
    }
}
