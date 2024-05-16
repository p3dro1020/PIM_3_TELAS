using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelaPIM
{
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
            FormShow(new FrmProducts());
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
    }
}
