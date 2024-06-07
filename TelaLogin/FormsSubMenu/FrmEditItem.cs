﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmEditItem : Form
    {
        public FrmEditItem()
        {
            InitializeComponent();
        }

        private void SomaValor()
        {
            // multiplica valor unitario pela quantidade
            if (txt_qtd.Text == "")
            {
                return;
            }

            if (txt_preco_unico.Text == "")
            {
                return;
            }

            double valor = Convert.ToDouble(txt_preco_unico.Text.Replace("R$ ", "")) * Convert.ToDouble(txt_qtd.Text);
            txt_valor_total.Text = "R$ " + valor.ToString("0.00");

        }


        private void txt_qtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // so permite numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_qtd_TextChanged(object sender, EventArgs e)
        {
            SomaValor();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            //verifica se o campo de quantidade está vazio
            if (txt_qtd.Text == "")
            {
                MessageBox.Show("Preencha o campo de quantidade");
                return;
            }

            this.Close();
        }

        public int deletar = 0;

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            deletar = 1;
            MessageBox.Show("Item excluido com sucesso!");
            this.Close();
        }
    }
}