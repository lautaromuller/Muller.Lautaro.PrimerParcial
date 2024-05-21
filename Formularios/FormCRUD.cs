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
        public FormCRUD()
        {
            InitializeComponent();
        }

        private void btnPinguino_Click(object sender, EventArgs e)
        {
            FormPinguino form = new FormPinguino();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Pinguino pinguino = form.Pinguino;
                this.listBox1.Items.Add(pinguino);
            }
        }

        private void btnColibri_Click(object sender, EventArgs e)
        {
            FormColibri form = new FormColibri();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Colibri colibri = form.Colibri;
                this.listBox1.Items.Add(colibri);
            }
        }

        private void btnHalcon_Click(object sender, EventArgs e)
        {
            FormHalcon form = new FormHalcon();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Halcon halcon = form.Halcon;
                this.listBox1.Items.Add(halcon);
            }
        }
    }
}
