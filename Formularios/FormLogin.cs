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
                    string infoUsuario = usuario.ToString();
                    Logueado.Loguear(infoUsuario);
                    FormCRUD form = new FormCRUD(usuario.nombre);
                    form.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Los datos son incorrectos");
        }
    }
}
