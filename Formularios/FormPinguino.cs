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
    public partial class FormPinguino : Form
    {
        public Pinguino pinguino;
        public Raza raza;
        public bool vuela;
        public bool frio;
        public bool manada;
        public FormPinguino()
        {
            InitializeComponent();
        }

        public FormPinguino(Pinguino pinguino) : this()
        {
            this.pinguino = pinguino;
            this.raza = pinguino.raza;
            this.txtNombre.Text = pinguino.nombre;
            this.txtHabitat.Text = pinguino.habitat;
            this.vuela = pinguino.puedeVolar;
            this.txtTipo.Text = pinguino.tipo;
            this.frio = pinguino.leGustaElFrio;
            this.manada = pinguino.viveEnManada;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.raza = ObtenerRaza();
            this.vuela = Vuela();
            this.frio = LeGustaElFrio();
            this.manada = ViveEnManada();
            this.pinguino = new Pinguino(raza, txtNombre.Text, txtHabitat.Text, vuela, txtTipo.Text, frio,manada);
            this.DialogResult = DialogResult.OK;
        }

        private Raza ObtenerRaza()
        {
            if (rbRazaPinguino.Checked)
            {
                return Entidades.Raza.Pinguino;
            } else if (rbRazaHalcon.Checked)
            {
                return Entidades.Raza.Halcón;
            } else if (rbRazaColibri.Checked)
            {
                return Entidades.Raza.Colibrí;
            }
            else
            {
                return Entidades.Raza.Ave;
            }
        }

        private bool Vuela()
        {
            if (rbVuelaSi.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LeGustaElFrio()
        {
            if (rbFrioSi.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ViveEnManada()
        {
            if (rbManadaSi.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
