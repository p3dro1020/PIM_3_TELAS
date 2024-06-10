using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.Infra;
using TelaLogin.Class;
using TelaLogin.ClassGlobal;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmAlterItem : Form
    {
        public string nome;
        public string un;
        public string preco;
        DBsupplier dbSupplier = new DBsupplier();

        public FrmAlterItem()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_nome.Text == "" || txt_codigo_barras.Text == "" || txt_categoria.Text == "" || txt_preco_custo.Text == "" || txt_porcentagem.Text == "" || txt_estoque_minimo.Text == "" || txt_fornecedor.Text == "" || cb_un.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }


            Item item = new Item();
            item.IdFornecedor = VarGlobal.id;
            item.CodigoBarras = txt_codigo_barras.Text;
            item.NomeItem = txt_nome.Text;
            item.Categoria = txt_categoria.Text;
            item.Un = cb_un.Text;
            item.PrecoCusto = Convert.ToDouble(txt_preco_custo.Text);
            item.Porcentagem = Convert.ToDouble(txt_porcentagem.Text);
            item.PrecoVenda = item.PrecoCusto + (item.PrecoCusto * item.Porcentagem / 100);
            item.Lucro = item.PrecoVenda - item.PrecoCusto;
            item.EstoqueMinimo = Convert.ToInt32(txt_estoque_minimo.Text);
            item.NomeFornecedor = txt_fornecedor.Text;



            if (dbSupplier.AddNewItem(item))
            {
                MessageBox.Show("Item adicionado com sucesso!");
                this.Close();
            }

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_nome.Text == "" || txt_codigo_barras.Text == "" || txt_categoria.Text == "" || txt_preco_custo.Text == "" || txt_porcentagem.Text == "" || txt_estoque_minimo.Text == "" || txt_fornecedor.Text == "" || cb_un.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            /*
            // verifica se algum dado foi alterado
            if (nome == txt_nomeItem.Text && un == txt_un.Text && preco == txt_preco.Text)
            {
                MessageBox.Show("Nenhum dado foi alterado!");
                return;
            }
            */
            Item item = new Item();
            item.IdFornecedor = VarGlobal.id;
            item.CodigoBarras = txt_codigo_barras.Text;
            item.NomeFornecedor = txt_fornecedor.Text;
            item.NomeItem = txt_nome.Text;
            item.Categoria = txt_categoria.Text;
            item.Un = cb_un.Text;
            item.PrecoCusto = Convert.ToDouble(txt_preco_custo.Text);
            item.Porcentagem = Convert.ToDouble(txt_porcentagem.Text);
            item.PrecoVenda = item.PrecoCusto + (item.PrecoCusto * item.Porcentagem / 100);
            item.Lucro = item.PrecoVenda - item.PrecoCusto;
            item.EstoqueMinimo = Convert.ToInt32(txt_estoque_minimo.Text);
            item.IdItem = VarGlobal.id_item;

            if (dbSupplier.UpdateItem(item))
            {
                MessageBox.Show("Item alterado com sucesso");
                this.Close();
            }

        }

        private void SomarLucro()
        {
            //verifica se os campos foram preenchidos
            if (txt_preco_custo.Text == "" || txt_porcentagem.Text == "")
            {
                return;
            }
            double preco = Convert.ToDouble(txt_preco_custo.Text);
            double porcentagem = Convert.ToDouble(txt_porcentagem.Text);
            double precoVenda = preco + (preco * porcentagem / 100);
            txt_valor_venda.Text = precoVenda.ToString();


            double lucro = precoVenda - preco;

            // formata lucro com 2 casas decimais
            lucro = Math.Round(lucro, 2);
            txt_lucro.Text = lucro.ToString();
        }

        private void txt_preco_custo_TextChanged(object sender, EventArgs e)
        {

            // verifica se o campo porcentagem foi preenchido
            if (txt_porcentagem.Text == "")
            {
                return;
            }

            SomarLucro();
        }

        private void txt_porcentagem_TextChanged(object sender, EventArgs e)
        {
            if (txt_preco_custo.Text == "")
            {
                return;
            }
            SomarLucro();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // enviar mensagem de confirmação
            DialogResult result = MessageBox.Show("Deseja excluir este item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dbSupplier.DeleteItem(VarGlobal.id_item))
                {
                    MessageBox.Show("Item excluído com sucesso!");
                    this.Close();
                }
            }
        }

        private void txt_preco_custo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // so aceita numeros, virgula e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_porcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // so aceita numeros e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
