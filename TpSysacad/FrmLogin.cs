using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;

namespace Formularios

{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string dni = txtUsuario.Text; // de momento se usa el dni de usuario
            string contrase�a = txtContrase�a.Text;
            bool verificado = false;


            ControlLogin controlLogin = new();
            bool existeUsuarios = controlLogin.ExisteUsuario;

            if (existeUsuarios)
            {

                verificado = controlLogin.AutenticarUsuario(dni, contrase�a);
                if (verificado)
                {
                    Usuario usuarioActual = controlLogin.GetUsuario;
                    FormPanelUsuario frmPanelUsuario = new(usuarioActual);

                    frmPanelUsuario.FormClosed += (sender, args) =>
                    {
                        this.Close();
                    };
                    frmPanelUsuario.Show();

                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Usuario o contrase�a Incorrecta");
                    txtUsuario.Text = string.Empty;
                    txtContrase�a.Text = string.Empty;

                }
            }
            else
            {
                MessageBox.Show("No se puede acceder en estos momentos");
            }

        }

        private void btnAutompletar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "011";
            txtContrase�a.Text = "11";
        }

        private void btnAutEstudiante_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "41928705";
            txtContrase�a.Text = "p3odag<g5";
        }
    }
}