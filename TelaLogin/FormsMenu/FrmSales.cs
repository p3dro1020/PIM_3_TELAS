using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPIM
{
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {

        }

        private void txt_cod_barras_KeyUp(object sender, KeyEventArgs e)
        {
            // verifica se a tecla soltada foi o enter
            if (e.KeyCode == Keys.Enter)
            {
                // verifica se o campo de código de barras está vazio
                if (txt_cod_barras.Text == "")
                {
                    MessageBox.Show("Digite o código de barras do produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }
        }
    }
}
