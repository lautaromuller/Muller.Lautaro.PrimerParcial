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
        private List<Ave> aves;
        public FormCRUD()
        {
            InitializeComponent();
            this.aves = new List<Ave>();
        }

        private void Actualizarvisor()
        {
            this.listBox1.Items.Clear();
            foreach (var item in aves)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }

        private void btnAgregarPinguino_Click(object sender, EventArgs e)
        {
            FormPinguino form = new FormPinguino();

            if(form.ShowDialog() == DialogResult.OK)
            {
                this.aves.Add(form.pinguino);
                Actualizarvisor();
            }
        }
    }
}
