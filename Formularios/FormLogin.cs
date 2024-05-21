using System.Text.Json;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string miJson = File.ReadAllText("data.json");
            List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(miJson);

            foreach (var usuario in usuarios)
            {
                if (usuario.correo == txtCorreo.Text && usuario.clave == txtContrasena.Text)
                {
                    FormCRUD form = new FormCRUD();
                    form.Show();
                    return;
                }
            }

            MessageBox.Show("Los datos son incorrectos");
        }
    }
}
