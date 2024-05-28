using TelaLogin.Infra;
using System.Windows;
using System.Windows.Forms;
using TelaPIM;

namespace TelaLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            //User userLogin = new User(); userLogin.scanUserPassword
            DBuser dbUser = new DBuser();
            string userTxtLogin = txtUser.Text;
            string userTxtPassword = txtPassword.Text;

            if (userTxtLogin == "" || userTxtPassword == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos");
                txtUser.Focus();
                return;
            }

            if (dbUser.VerifyUser(userTxtLogin, userTxtPassword))
            {
                MainMenu Menu = new MainMenu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                txtPassword.Clear();
                txtUser.Focus();
            }
            
        }
    }
}
