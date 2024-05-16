using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.Infra;
using TelaLogin.FormsMenu;
using TelaLogin.Class;

namespace TelaPIM
{
    public partial class FrmProduction : Form
    {
        DBconnect db = new DBconnect();
        FrmNewProduct frmNewProduct = new FrmNewProduct();
        public FrmProduction()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            frmNewProduct.ShowDialog();
        }

        private void FrmProduction_Load(object sender, EventArgs e)
        {
            List<Produto> produtos = db.ListAllProducts();
            // insere os produtos no datagridview
            foreach (Produto p in produtos)
            {
                dgv_Production.Rows.Add(p.Id, p.Nome, p.Quantidade, p.Data_plantio, p.Data_colheita);
            }
        }
    }
}
