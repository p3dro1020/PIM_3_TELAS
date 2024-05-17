﻿using System;
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
using TelaPIM;

namespace TelaLogin.FormsMenu
{
    public partial class FrmProductManagement : Form
    {
        public int id;
        DBconnect db = new DBconnect();
        public FrmProductManagement()
        {
            InitializeComponent();
        }



        private void alterarDataFinal()
        {
            // a partir da data selecionada, altera o valor da data final para x dias a frente
            if (cb_hortalica.Text == "")
            {
                return;
            }

            txt_days.Text = "Dias até a colheita: ";
            string hortalica = cb_hortalica.Text;
            int dias = 0;

            if (hortalica == "Alface")
            {
                dias = 70;
            }
            else if (hortalica == "Berinjela")
            {
                dias = 100;
            }
            else if (hortalica == "Brócolis")
            {
                dias = 90;
            }
            else if (hortalica == "Cebola")
            {
                dias = 150;
            }
            else if (hortalica == "Couve")
            {
                dias = 80;
            }
            else if (hortalica == "Couve Flor")
            {
                dias = 120;
            }
            else if (hortalica == "Morango")
            {
                dias = 70;
            }
            else if (hortalica == "Tomate")
            {
                dias = 120;
            }
            else if (hortalica == "Repolho")
            {
                dias = 120;
            }
            else if (hortalica == "Pimentão")
            {
                dias = 120;
            }

            DateTime dataInicio = dt_plantio.Value;
            DateTime dataFinal = dataInicio.AddDays(dias);
            dt_colheita.Value = dataFinal;
            txt_days.Text += dias.ToString();
        }

        private void cb_hortalica_SelectedIndexChanged(object sender, EventArgs e)
        {
            alterarDataFinal();
        }

        private void dt_plantio_ValueChanged(object sender, EventArgs e)
        {
            alterarDataFinal();
        }

        private void bt_addNewPlantio_Click(object sender, EventArgs e)
        {
            if (cb_hortalica.Text == "")
            {
                MessageBox.Show("Preencha o campo de hortaliças");
                return;
            }
            if (txt_qtd.Text == "")
            {
                MessageBox.Show("Preencha o campo de quantidade");
                return;
            }
            // if (cb_hortalica.Text == "") MessageBox.Show("Preencha o campo de hortaliças");
            // declara variaveis pra utilizar
            DBconnect db = new DBconnect();
            Produto p = new Produto();

            // insere os dados digitados nos textbox's para a classe produto
            p.Nome = cb_hortalica.Text;
            p.Data_plantio = dt_plantio.Value;
            p.Data_colheita = dt_colheita.Value;
            p.Quantidade = int.Parse(txt_qtd.Text);

            if (db.CreateProduct(p))
            {
                MessageBox.Show("Produto adicionado com sucesso!");
                this.Close();
            }

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {


            // enviar pergunta se deseja realmente editar
            DialogResult res = MessageBox.Show("Deseja realmente editar o produto?", "Editar", MessageBoxButtons.YesNo);

            // alterar o produto
            if (res == DialogResult.Yes)
            {
                Produto p = new Produto();
                p.Id = id;
                p.Nome = cb_hortalica.Text;
                p.Quantidade = int.Parse(txt_qtd.Text);
                p.Data_plantio = Convert.ToDateTime(dt_plantio.Text);
                p.Data_colheita = Convert.ToDateTime(dt_colheita.Text);
                
                if(db.UpdateProduct(p))
                {
                    MessageBox.Show("Produto alterado com sucesso!");
                    this.Close();
                }

            }

        }
    }
}
