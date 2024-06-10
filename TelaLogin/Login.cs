using TelaLogin.Infra;
using System.Windows;
using System.Windows.Forms;
using TelaPIM;
using TelaLogin.FormsMenu;

namespace TelaLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Select();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
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
                this.Hide();
                waitingFrm waitingFrm = new waitingFrm();
                waitingFrm.Show();
                MainMenu Menu = new MainMenu();
                await Task.Delay(3000);
                Menu.Show();
                waitingFrm.Close();
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
