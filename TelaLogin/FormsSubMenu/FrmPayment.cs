using System;
using System.Collections.Generic;
using System.ComponentModel;
using TelaLogin.Class;
using TelaLogin.ClassGlobal;
using TelaLogin.Infra;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmPayment : Form
    {
        public List<Item> Items;



        public FrmPayment()
        {
            InitializeComponent();
        }


        private void FrmPayment_Load(object sender, EventArgs e)
        {
            txt_desconto.Text = "R$ 00,00";
            txt_acrescimo.Text = "R$ 00,00";
            txt_troco.Visible = false;
            lb_troco.Visible = false;
            // soma o valor total da venda + juros de 2% dividido por 2
            double valor2x = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", "")) * 1.02 / 2;
            double valor3x = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", "")) * 1.03 / 3;



            txt_simulacao_dinheiro.Text = txt_valor_total.Text;
            txt_simulacao_pix.Text = txt_valor_total.Text;
            txt_simulacao_debito.Text = txt_valor_total.Text;
            txt_simulacao_credito_avista.Text = txt_valor_total.Text;
            txt_simulacao_credito2x.Text = $"2x de R$ {valor2x.ToString("0.00")} = R$ {(2 * valor2x).ToString("0.00")}";
            txt_simulacao_credito3x.Text = $"3x de R$ {valor3x.ToString("0.00")} = R$ {(3 * valor3x).ToString("0.00")}";
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (cb_pagamento.Text == "" || txt_valor_pago.Text == "" || txt_desconto.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pedido p = new Pedido();
            p.Total = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", ""));
            p.Desconto = Convert.ToDouble(txt_desconto.Text.Replace("R$ ", ""));
            p.Status = "Pago";
            p.Quantidade = VarGlobal.Qtd;

            DBpedido dbPedido = new DBpedido();
            if (dbPedido.AddNewPedido(p))
            {
                MessageBox.Show("Venda realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // insere os itens do pedido no banco de dados          
            foreach (Item i in Items)
            {
                dbPedido.AddItemPedido(i);
            }

        }

        private void cb_desconto_CheckedChanged(object sender, EventArgs e)
        {
            // verifica se o checkbox de desconto foi marcado
            if (cb_desconto.Checked)
            {
                // habilita o campo de desconto
                txt_desconto.Enabled = true;
                txt_desconto.Focus();
            }
            else
            {
                // desabilita o campo de desconto
                txt_desconto.Enabled = false;
                txt_desconto.Text = "R$ 00,00";
            }
        }

        private void cb_pagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // nao permite que o usuario digite no combobox
            e.Handled = true;


        }

        private void cb_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // verifica se a opção selecionada foi a de dinheiro
            if (cb_pagamento.Text == "Dinheiro")
            {
                txt_troco.Visible = true;
                lb_troco.Visible = true;
                txt_valor_pago.Focus();
                txt_troco.Text = "R$ 00,00";
            }
            else
            {
                txt_troco.Visible = false;
                lb_troco.Visible = false;
                txt_troco.Text = "R$ 00,00";
            }


            // verifica se a opção selecionada foi a de cartao 2x
            if (cb_pagamento.Text == "Cartão crédito 2x.")
            {
                double valor = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", "")) * 1.02 - Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", ""));
                txt_acrescimo.Text = $"R$ {valor.ToString("0.00")}";
            }else if (cb_pagamento.Text == "Cartão crédito 3x.")
            {
                double valor = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", "")) * 1.03 - Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", ""));
                txt_acrescimo.Text = $"R$ {valor.ToString("0.00")}";
            }
            else
            {
                txt_acrescimo.Text = "R$ 00,00";
            }
        }
    }
}
