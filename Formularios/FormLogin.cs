using Entidades;
using System.Text.Json;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador del evento click del boton Ingresar. Comprueba que el usuario esté registrado.
        /// </summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string miJson = File.ReadAllText("data_usuarios.json");
            List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(miJson);

            foreach (var usuario in usuarios)
            {
                if (usuario.correo == txtCorreo.Text && usuario.clave == txtContrasena.Text)
                {
                    this.Hide();
                    Logueado.Loguear(usuario.ToString());
                    FormCRUD form = new FormCRUD(usuario);
                    form.ShowDialog();
                    this.Close();
                }
            }
            MessageBox.Show("Los datos ingresados son incorrectos");
        }
    }
}
