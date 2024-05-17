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

        public FrmProduction()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void LoadProduct()
        {
            dgv_Production.Rows.Clear();
            List<Produto> produtos = db.ListAllProducts();
            // insere os produtos no datagridview
            foreach (Produto p in produtos)
            {
                dgv_Production.Rows.Add(p.Id, p.Nome, p.Quantidade, p.Data_plantio, p.Data_colheita, p.Status);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            FrmProductManagement frmProductManagement = new FrmProductManagement();
            frmProductManagement.bt_save.Enabled = false;
            frmProductManagement.bt_addNewPlantio.Enabled = true;
            frmProductManagement.ShowDialog();
            LoadProduct();
        }



        private void dgv_Production_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgv_Production.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FrmProductManagement frmProductManagement = new FrmProductManagement();
                frmProductManagement.bt_save.Enabled = true;
                frmProductManagement.bt_addNewPlantio.Enabled = false;
                frmProductManagement.cb_hortalica.Text = dgv_Production.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmProductManagement.txt_qtd.Text = dgv_Production.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmProductManagement.dt_plantio.Text = Convert.ToDateTime(dgv_Production.Rows[e.RowIndex].Cells[3].Value).ToString();
                frmProductManagement.id = Convert.ToInt32(dgv_Production.Rows[e.RowIndex].Cells["cod"].Value);
                frmProductManagement.ShowDialog();
                // recarrega o datagridview
                LoadProduct();
            }
            else if (colName == "Delete")
            {
                // confirma se o usuario deseja excluir
                DialogResult res = MessageBox.Show("Deseja realmente remover o produto?", "Remover", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    // pega o id do produto
                    int id = Convert.ToInt32(dgv_Production.Rows[e.RowIndex].Cells["cod"].Value);
                    // exclui o produto
                    db.ExcludeProduct(id);
                    // recarrega o datagridview
                    LoadProduct();
                }


            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Por favor digite algo");
                return;
            }

            dgv_Production.Rows.Clear();
            List<Produto> produtos = db.SearchProduct(txt_search.Text);
            // insere os produtos no datagridview
            foreach (Produto p in produtos)
            {
                dgv_Production.Rows.Add(p.Id, p.Nome, p.Quantidade, p.Data_plantio, p.Data_colheita, p.Status);
            }
        }

        private void bt_listAll_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            LoadProduct();
        }
    }
}
