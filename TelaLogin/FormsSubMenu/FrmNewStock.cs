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
using TelaLogin.Class;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmNewStock : Form
    {
        public FrmNewStock()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            DBstock dbStock = new DBstock();
            ItemEstoque itemEstoque = new ItemEstoque();
            itemEstoque.Quantidade = Convert.ToInt32(txt_qtd.Text);
            itemEstoque.IdItem = Convert.ToInt32(txt_produto.Text);
            if (dbStock.UpdateStock(itemEstoque))
            {
                MessageBox.Show("Estoque atualizado com sucesso!");
                this.Close();
            }

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            DBstock dbStock = new DBstock();
            ItemEstoque itemEstoque = new ItemEstoque();
            itemEstoque.IdItem = Convert.ToInt32(txt_produto.Text);
            itemEstoque.CodigoBarras = txt_cdg_barra.Text;
            itemEstoque.Nome = txt_nome.Text;
            itemEstoque.Categoria = txt_categoria.Text;
            itemEstoque.Unidade = txt_unidade.Text;
            itemEstoque.Quantidade = Convert.ToInt32(txt_qtd.Text);
            itemEstoque.Preco = Convert.ToDouble(txt_preco_venda.Text);
            itemEstoque.Fornecedor = txt_fornecedor.Text;
            if (dbStock.CreateStock(itemEstoque))
            {
                MessageBox.Show("Estoque adicionado com sucesso!");
                this.Close();
            }
        }

        private void txt_cdg_barra_KeyUp(object sender, KeyEventArgs e)
        {
            // verifica se a tecla pressionada foi enter
            if (e.KeyCode == Keys.Enter)
            {
                DBstock dbStock = new DBstock();
                ItemEstoque itemEstoque = dbStock.SearchStock(txt_cdg_barra.Text);
                if (itemEstoque != null)
                {
                    txt_produto.Text = itemEstoque.IdItem.ToString();
                    txt_nome.Text = itemEstoque.Nome;
                    txt_categoria.Text = itemEstoque.Categoria;
                    txt_unidade.Text = itemEstoque.Unidade;
                    txt_preco_venda.Text = itemEstoque.Preco.ToString();
                    txt_fornecedor.Text = itemEstoque.Fornecedor;
                    bt_save.Enabled = true;
                }
                else
                {
                    txt_produto.Clear();
                    txt_nome.Clear();
                    txt_categoria.Clear();
                    txt_unidade.Clear();
                    txt_qtd.Clear();
                    txt_preco_venda.Clear();
                    txt_fornecedor.Clear();
                    bt_save.Enabled = false;
                }
            }
        }
    }
}
