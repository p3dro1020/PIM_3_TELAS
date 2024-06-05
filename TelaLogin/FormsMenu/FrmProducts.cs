using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.Class;
using TelaLogin.Infra;
using TelaLogin.FormsSubMenu;

namespace TelaPIM
{
    public partial class FrmProducts : Form
    {
        private DBstock dbStock = new DBstock();
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void LoadEstoque()
        {
            dgv_stock.Rows.Clear();
            List<ItemEstoque> itemEstoque = dbStock.GetAllStock();

            // insere os produtos no datagridview
            foreach (ItemEstoque ie in itemEstoque)
            {
                dgv_stock.Rows.Add(ie.IdItem, ie.CodigoBarras, ie.Nome, ie.Categoria, ie.Quantidade, ie.Unidade, ie.Preco, ie.Quantidade * ie.Preco, ie.Fornecedor);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            FrmNewStock frmNewStock = new FrmNewStock();
            // desativa o botao de deletar e de salvar
            frmNewStock.bt_save.Enabled = false;

            // limpa os campos
            frmNewStock.txt_cdg_barra.Clear();
            frmNewStock.txt_nome.Clear();
            frmNewStock.txt_categoria.Clear();
            frmNewStock.txt_unidade.Clear();
            frmNewStock.txt_qtd.Clear();
            frmNewStock.txt_preco_venda.Clear();
            frmNewStock.txt_fornecedor.Clear();

            frmNewStock.ShowDialog();
            LoadEstoque();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadEstoque();
        }

        private void dgv_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica se a coluna clicada foi a de editar
            if (e.ColumnIndex == dgv_stock.Columns["edit"].Index)
            {
                FrmNewStock frmNewStock = new FrmNewStock();
                // ativa o botao de deletar e de salvar
                frmNewStock.bt_save.Enabled = true;
                frmNewStock.bt_add.Enabled = false;
                frmNewStock.txt_cdg_barra.Enabled = false;

                // preenche os campos com os valores do datagridview
                frmNewStock.txt_cdg_barra.Text = dgv_stock.Rows[e.RowIndex].Cells["cod_barras"].Value.ToString();
                frmNewStock.txt_nome.Text = dgv_stock.Rows[e.RowIndex].Cells["name"].Value.ToString();
                frmNewStock.txt_categoria.Text = dgv_stock.Rows[e.RowIndex].Cells["category"].Value.ToString();
                frmNewStock.txt_unidade.Text = dgv_stock.Rows[e.RowIndex].Cells["un"].Value.ToString();
                frmNewStock.txt_qtd.Text = dgv_stock.Rows[e.RowIndex].Cells["qtd"].Value.ToString();
                frmNewStock.txt_preco_venda.Text = dgv_stock.Rows[e.RowIndex].Cells["preco_unico"].Value.ToString();
                frmNewStock.txt_fornecedor.Text = dgv_stock.Rows[e.RowIndex].Cells["fornecedor"].Value.ToString();
                frmNewStock.txt_produto.Text = dgv_stock.Rows[e.RowIndex].Cells["cod"].Value.ToString();

                frmNewStock.ShowDialog();
                LoadEstoque();
            }
            else if (e.ColumnIndex == dgv_stock.Columns["delete"].Index)
            {
                if (MessageBox.Show("Deseja realmente deletar este item?", "Deletar item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dbStock.DeleteStock(Convert.ToInt32(dgv_stock.Rows[e.RowIndex].Cells["cod"].Value));
                    LoadEstoque();
                }
            }
        }
    }
}
