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
        DBproduct dbProduct = new DBproduct();

        public FrmProduction()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void LoadProduct()
        {
            dgv_Production.Rows.Clear();
            List<Plantio> plantio = dbProduct.ListAllProducts();
            // insere os produtos no datagridview
            foreach (Plantio p in plantio)
            {
                dgv_Production.Rows.Add(p.Id, p.Nome, p.Quantidade, p.DataPlantioFormatada, p.DataColheitaFormatada, p.Status);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            FrmProductManagement frmProductManagement = new FrmProductManagement();
            frmProductManagement.bt_save.Enabled = false;
            frmProductManagement.bt_addNewPlantio.Enabled = true;
            frmProductManagement.txt_status.Visible = false;
            frmProductManagement.cb_status.Visible = false;
            frmProductManagement.ShowDialog();
            LoadProduct();
        }



        private void dgv_Production_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgv_Production.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FrmProductManagement frmProductManagement = new FrmProductManagement();
                // ativa o bt de salvar e desativa botao de adicionar
                frmProductManagement.bt_save.Enabled = true;
                frmProductManagement.bt_addNewPlantio.Enabled = false;
                frmProductManagement.txt_status.Visible = true;
                frmProductManagement.cb_status.Visible = true;

                // envia dados do formulario Production para o formulario Product Management
                frmProductManagement.cb_hortalica.Text = dgv_Production.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmProductManagement.txt_qtd.Text = dgv_Production.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmProductManagement.dt_plantio.Text = Convert.ToDateTime(dgv_Production.Rows[e.RowIndex].Cells[3].Value).ToString();
                // txt dias recebe data colheita - data plantio
                frmProductManagement.txt_dias_colheita.Text = (Convert.ToDateTime(dgv_Production.Rows[e.RowIndex].Cells[4].Value) - Convert.ToDateTime(dgv_Production.Rows[e.RowIndex].Cells[3].Value)).TotalDays.ToString();
                frmProductManagement.cb_status.Text = dgv_Production.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                    dbProduct.DeleteProduct(id);
                    // recarrega o datagridview
                    LoadProduct();
                }


            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Por favor digite algo para pesquisar");
                txt_search.Focus();
                return;
            }

            if(rb_nome.Checked == false && rb_status.Checked == false)
            {
                MessageBox.Show("Por favor selecione um filtro de pesquisa");
                return;
            }

            if (rb_nome.Checked == true)
            {
                // busca os plantios
                List<Plantio> produtos = dbProduct.SearchProduct(txt_search.Text);

                // verifica se a lista de plantios esta vazia
                if (produtos.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado");
                    //LoadProduct();

                    txt_search.Focus();
                    return;
                }

                // limpa o datagridview
                dgv_Production.Rows.Clear();
                // insere os produtos buscados no datagridview
                foreach (Plantio p in produtos)
                {
                    dgv_Production.Rows.Add(p.Id, p.Nome, p.Quantidade, p.DataPlantioFormatada, p.DataColheitaFormatada, p.Status);
                }
            }
            else if(rb_status.Checked == true)
            {
                // busca os plantios
                List<Plantio> produtos = dbProduct.SearchProductStatus(txt_search.Text);

                // verifica se a lista de plantios esta vazia
                if (produtos.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado");
                    //LoadProduct();

                    txt_search.Focus();
                    return;
                }

                // limpa o datagridview
                dgv_Production.Rows.Clear();
                // insere os produtos buscados no datagridview
                foreach (Plantio p in produtos)
                {
                    dgv_Production.Rows.Add(p.Id, p.Nome, p.Quantidade, p.DataPlantioFormatada, p.DataColheitaFormatada, p.Status);
                }
            }
        }

        private void bt_listAll_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            LoadProduct();
        }
    }
}
