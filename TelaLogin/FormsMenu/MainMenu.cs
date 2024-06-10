using TelaLogin.Infra;
using TelaLogin.ClassGlobal;
using TelaLogin.Class;

namespace TelaPIM
{
    // alteração feita no navegador
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private Form FrmAtivo;

        private void FormShow(Form frm)
        {
            ActivateFormClose();
            FrmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActivateFormClose()
        {
            if (FrmAtivo != null)
            {
                FrmAtivo.Close();
            }
        }

        private void ActivateButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelMenu.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Gray;
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            ActivateButton(btnHome);
            ActivateFormClose();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActivateButton(btnEmployees);
            FormShow(new FrmEmployees());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProducts);
            FormShow(new FrmStock());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSuppliers);
            FormShow(new FrmSuppliers());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSales);
            FormShow(new FrmSales());
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProduction);
            FormShow(new FrmProduction());
        }

        private void MainMenu_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadDgvs()
        {
            DBsale dBsale = new DBsale();
            List<Venda> v = new List<Venda>();
            v = dBsale.SearchLastSales();


            foreach (Venda item in v)
            {
                dgv_lastSale.Rows.Add(item.DataVenda.ToString("dd/MM/yyyy"), item.Produto, "R$ " + item.ValorTotal.ToString("0.00"), "R$ " + item.Ganhos);
            }

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            txt_nomeUsuario.Text = VarGlobal.NomeUsuario;
            LoadDgvs();
        }
    }
}
