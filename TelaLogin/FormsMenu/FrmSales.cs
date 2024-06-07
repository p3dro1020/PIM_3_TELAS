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
using TelaLogin.ClassGlobal;
using TelaLogin.FormsSubMenu;
using TelaLogin.Infra;



namespace TelaPIM
{
    public partial class FrmSales : Form
    {

        public int CodigoProduto = 0;
        public FrmSales()
        {
            InitializeComponent();
            dgv_sales.RowsAdded += dgv_sales_RowsAdded;
            dgv_sales.RowsRemoved += dgv_sales_RowsRemoved;
            dgv_sales.UserDeletedRow += dgv_sales_UserDeletedRow;
        }

        private void SomaValorDgv()
        {
            // percorre as linhas do dgv somando e adiciona no txtTotal
            double total = 0;
            for (int i = 0; i < dgv_sales.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgv_sales.Rows[i].Cells["preco_total"].Value.ToString().Replace("R$ ", ""));
            }
            txtTotal.Text = "R$ " + total.ToString("0.00");
        }

        private void SomarValor()
        {
            // verifica se o campo de quantidade de produto está vazio
            if (txt_qtd_produto.Text == "")
            {
                return;
            }

            // verifica se o campo de valor unitário está vazio
            if (txt_valor_un.Text == "")
            {
                return;
            }

            // calcula o valor total com duas casas decimais
            double valor = Convert.ToDouble(txt_valor_un.Text) * Convert.ToDouble(txt_qtd_produto.Text);
            txt_valor_tot.Text = valor.ToString("0.00");

        }

        // metodo para pegar o ultimo pedido
        private void GetLastSale()
        {
            DBpedido dbPedido = new DBpedido();
            Pedido p = new Pedido();
            p = dbPedido.GetProxPedido();
            txt_num_venda.Text = (p.IdPedido + 1).ToString();

        }

        private void GetSystemDate()
        {
            txt_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            GetLastSale();
            GetSystemDate();
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
                // instancia a classe DBsale e Venda
                DBsale dbSale = new DBsale();
                Venda v = new Venda();
                v = dbSale.SearchProductByBarCode(txt_cod_barras.Text);

                // verifica se encontro o produto
                if (v == null)
                {
                    MessageBox.Show("Produto não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // verifica se o codigo do produto ja esta inserido no dgv
                for (int i = 0; i < dgv_sales.Rows.Count; i++)
                {
                    if (v.CodigoProduto == Convert.ToInt32(dgv_sales.Rows[i].Cells["cod"].Value))
                    {
                        MessageBox.Show("Produto já inserido na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpaTextBox();
                        txt_cod_barras.Focus();
                        return;
                    }
                }

                // insere os dados no text box
                txt_produto.Text = v.Produto;
                txt_unidade.Text = v.Unidade;
                txt_valor_un.Text = v.ValorUnitario.ToString();
                CodigoProduto = v.CodigoProduto;

                // posiciona o cursor no campo quantidade de produto
                txt_qtd_produto.Focus();

            }
        }

        private void txt_qtd_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // so digita o texto se for um numero ou backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void txt_qtd_produto_TextChanged(object sender, EventArgs e)
        {
            SomarValor();
        }

        private void txt_valor_un_TextChanged(object sender, EventArgs e)
        {
            SomarValor();
        }

        private void CalculaTotal()
        {
            // calcula o total da venda de todos os itens
            double total = 0;
            for (int i = 0; i < dgv_sales.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgv_sales.Rows[i].Cells["preco_total"].Value.ToString().Replace("R$ ", ""));
            }
            txtTotal.Text = "R$ " + total.ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_cod_barras.Text == "" || txt_qtd_produto.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            // insere os dados no data grid view
            dgv_sales.Rows.Add("", CodigoProduto, txt_unidade.Text, txt_produto.Text, "R$ " + txt_valor_un.Text, txt_qtd_produto.Text, "R$ " + txt_valor_tot.Text);

            CalculaTotal();


            // limpa todos os campos e posiciona o cursor no campo codigo barra
            LimpaTextBox();
            txt_cod_barras.Focus();



        }

        private void LimpaTextBox()
        {
            txt_cod_barras.Clear();
            txt_produto.Clear();
            txt_qtd_produto.Clear();
            txt_valor_un.Clear();
            txt_unidade.Clear();
            txt_valor_tot.Clear();
        }

        // qualquer alteracao do dgv_sales aciona o metodo UpdateRowIndices
        private void dgv_sales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateRowIndices(sender as DataGridView);
            SomaValorDgv();

        }

        private void dgv_sales_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateRowIndices(sender as DataGridView);
            SomaValorDgv();

        }

        private void dgv_sales_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateRowIndices(sender as DataGridView);
            SomaValorDgv();
        }

        // atualiza o indice da linha
        private void UpdateRowIndices(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["contador"].Value = i + 1;
            }
            //insere a quantidade de itens no campo quantidade de itens
            txtItem.Text = dgv.Rows.Count.ToString();

        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            // verifica se existe itens no datagridview
            if (dgv_sales.Rows.Count == 0)
            {
                MessageBox.Show("Adicione itens a lista de vendas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VarGlobal.Qtd = Convert.ToInt32(txtItem.Text);


            List<Item> it = new List<Item>();
            // envia os dados do datagridview para o form de pagamento
            for (int i = 0; i < dgv_sales.Rows.Count; i++)
            {
                // Ignora a linha de nova entrada
                if (dgv_sales.Rows[i].IsNewRow)
                    continue;

                Item item = new Item();

                // Verifica se as células não são nulas antes de acessar os valores
                if (dgv_sales.Rows[i].Cells["cod"].Value != null)
                {
                    item.IdItem = Convert.ToInt32(dgv_sales.Rows[i].Cells["cod"].Value);
                }

                if (dgv_sales.Rows[i].Cells["qtd"].Value != null)
                {
                    item.Quantidade = Convert.ToInt32(dgv_sales.Rows[i].Cells["qtd"].Value);
                }

                if (dgv_sales.Rows[i].Cells["valor"].Value != null)
                {
                    item.PrecoVenda = Convert.ToDouble(dgv_sales.Rows[i].Cells["valor"].Value.ToString().Replace("R$ ", ""));
                }
                item.IdPedido = Convert.ToInt32(txt_num_venda.Text);
                it.Add(item);
            }
            // verifica se it é null
            if (it == null)
            {
                MessageBox.Show("Erro ao enviar os dados para o form de pagamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmPayment frmPayment = new FrmPayment();
            frmPayment.Items = it;
            frmPayment.txt_valor_total.Text = txtTotal.Text;
            frmPayment.ShowDialog();
        }

        private void dgv_sales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            FrmEditItem frmEditItem = new FrmEditItem();
            frmEditItem.txt_produto.Text = dgv_sales.Rows[e.RowIndex].Cells["name"].Value.ToString();
            frmEditItem.txt_qtd.Text = dgv_sales.Rows[e.RowIndex].Cells["qtd"].Value.ToString();
            frmEditItem.txt_preco_unico.Text = dgv_sales.Rows[e.RowIndex].Cells["valor"].Value.ToString();
            frmEditItem.txt_valor_total.Text = dgv_sales.Rows[e.RowIndex].Cells["preco_total"].Value.ToString();
            frmEditItem.ShowDialog();

            if(frmEditItem.deletar != 1)
            {
                // altera os valores do datagridview
                dgv_sales.Rows[e.RowIndex].Cells["qtd"].Value = frmEditItem.txt_qtd.Text;
                dgv_sales.Rows[e.RowIndex].Cells["preco_total"].Value = frmEditItem.txt_valor_total.Text;
                SomaValorDgv();
            }
            else
            {
                // apaga o item do datagridview
                dgv_sales.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
