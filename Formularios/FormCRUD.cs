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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un ave para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(this.listBox1.SelectedItem is Pinguino)
            {
                Pinguino seleccionado = (Pinguino)listBox1.SelectedItem;
                FormPinguino form = new FormPinguino(seleccionado);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var pinguino = form.Pinguino;
                    int selectedIndex = listBox1.SelectedIndex;
                    listBox1.Items[selectedIndex] = pinguino;
                }
            }
            else if(this.listBox1.SelectedItem is Colibri)
            {
                Colibri seleccionado = (Colibri)listBox1.SelectedItem;
                FormColibri form = new FormColibri(seleccionado);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var colibri = form.Colibri;
                    int selectedIndex = listBox1.SelectedIndex;
                    listBox1.Items[selectedIndex] = colibri;
                }
            }
            else
            {
                Halcon seleccionado = (Halcon)listBox1.SelectedItem;
                FormHalcon form = new FormHalcon(seleccionado);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var halcon = form.Halcon;
                    int selectedIndex = listBox1.SelectedIndex;
                    listBox1.Items[selectedIndex] = halcon;
                }
            }
        }
    }
}
