using TelaLogin.Infra;
using TelaLogin.Class;
using TelaLogin.FormsMenu;
using TelaPIM;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmNewStock : Form
    {
        public DataGridView dgvRow = new DataGridView();

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
            // verifica se todos os campos foram preenchidos
            if (txt_produto.Text == "" || txt_cdg_barra.Text == "" || txt_nome.Text == "" || txt_categoria.Text == "" || txt_unidade.Text == "" || txt_qtd.Text == "" || txt_preco_venda.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            //verifica se o campo qtd é maior que 0
            if (Convert.ToInt32(txt_qtd.Text) <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que 0!");
                return;
            }

            // verifica se o item ja esta contido no dgv
            foreach (DataGridViewRow row in dgvRow.Rows)
            {
                if (row.Cells[1].Value.ToString() == txt_cdg_barra.Text)
                {
                    MessageBox.Show("Produto já adicionado!");
                    // limpa os campos
                    txt_produto.Clear();
                    txt_cdg_barra.Clear();
                    txt_nome.Clear();
                    txt_categoria.Clear();
                    txt_unidade.Clear();
                    txt_qtd.Clear();
                    txt_preco_venda.Clear();
                    txt_fornecedor.Clear();
                    txt_cdg_barra.Focus();
                    return;
                }
            }

            DBstock dbStock = new DBstock();
            ItemEstoque itemEstoque = new ItemEstoque();
            itemEstoque.IdItem = Convert.ToInt32(txt_produto.Text);
            itemEstoque.CodigoBarras = txt_cdg_barra.Text;
            itemEstoque.Nome = txt_nome.Text;
            itemEstoque.Categoria = txt_categoria.Text;
            itemEstoque.Unidade = txt_unidade.Text;
            itemEstoque.Quantidade = Convert.ToInt32(txt_qtd.Text);
            itemEstoque.Preco = Convert.ToDouble(txt_preco_venda.Text.Replace("R$ ", ""));
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
                // verifica se encontrou o produto
                if (itemEstoque != null)
                {
                    txt_produto.Text = itemEstoque.IdItem.ToString();
                    txt_nome.Text = itemEstoque.Nome;
                    txt_categoria.Text = itemEstoque.Categoria;
                    txt_unidade.Text = itemEstoque.Unidade;
                    txt_preco_venda.Text = "R$ " + itemEstoque.Preco.ToString();
                    txt_fornecedor.Text = itemEstoque.Fornecedor;
                    bt_save.Enabled = true;
                    txt_qtd.Focus();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
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

        private void txt_qtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // so aceita numeros e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
