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
using TelaPIM;

namespace TelaLogin.FormsMenu
{
    public partial class FrmProductManagement : Form
    {
        public int id;


        public FrmProductManagement()
        {
            InitializeComponent();
        }



        private void alterarDataFinal()
        {
            // a partir da data selecionada, altera o valor da data final para x dias a frente

            if(txt_dias_colheita.Text == "")
            {
                return;
            }

            // verifica se o numero digitado no txt_dias_colheita + a data de plantio é menor que a data limite 01/01/2026
            if (dt_plantio.Value.AddDays(int.Parse(txt_dias_colheita.Text)) > Convert.ToDateTime("01/01/2026"))
            {
                MessageBox.Show("Data de colheita não pode ser maior que o limite do sistema 01/01/2026");
                txt_dias_colheita.Clear();
                txt_dias_colheita.Focus();
                return;
            }

            // verifica se o campo de dias de colheita é um numero
            if (!int.TryParse(txt_dias_colheita.Text, out int n))
            {
                return;
            }

            DateTime dataInicio = dt_plantio.Value;
            DateTime dataFinal = dataInicio.AddDays(int.Parse(txt_dias_colheita.Text));
            dt_colheita.Value = dataFinal;
        }


        private void dt_plantio_ValueChanged(object sender, EventArgs e)
        {
            alterarDataFinal();
        }

        private void bt_addNewPlantio_Click(object sender, EventArgs e)
        {
            if (cb_hortalica.Text == "" || txt_qtd.Text == "" || txt_dias_colheita.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }


            // declara variaveis pra utilizar
            DBproduct dbProduct = new DBproduct();
            Plantio p = new Plantio();

            // insere os dados digitados nos textbox's para a classe produto
            p.Nome = cb_hortalica.Text;
            p.Data_plantio = dt_plantio.Value;
            p.Data_colheita = dt_colheita.Value;
            p.Quantidade = int.Parse(txt_qtd.Text);

            if (dbProduct.CreateProduct(p))
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
            // verifica se todos os campos foram preenchidos
            if (cb_hortalica.Text == "" || txt_qtd.Text == "" || txt_dias_colheita.Text == "" || cb_status.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            // enviar pergunta se deseja realmente editar
            DialogResult res = MessageBox.Show("Deseja realmente editar o produto?", "Editar", MessageBoxButtons.YesNo);

            // alterar o produto
            if (res == DialogResult.Yes)
            {
                DBproduct dbProduct = new DBproduct();
                Plantio p = new Plantio();


                if (cb_status.Text == "Germinando")
                {
                    p.Status = "G";
                }
                else if (cb_status.Text == "Em crescimento")
                {
                    p.Status = "EC";
                }
                else if (cb_status.Text == "Pronto colheita")
                {
                    p.Status = "PC";
                }
                else if (cb_status.Text == "Colhido")
                {
                    p.Status = "C";
                }




                p.Id = id;
                p.Nome = cb_hortalica.Text;
                p.Quantidade = int.Parse(txt_qtd.Text);
                p.Data_plantio = Convert.ToDateTime(dt_plantio.Text);
                p.Data_colheita = Convert.ToDateTime(dt_colheita.Text);

                if (dbProduct.UpdateProduct(p))
                {
                    MessageBox.Show("Produto alterado com sucesso!");
                    this.Close();
                }

            }

        }

        private void txt_dias_colheita_KeyPress(object sender, KeyPressEventArgs e)
        {
            // so aceita digitos numericos e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_dias_colheita_TextChanged(object sender, EventArgs e)
        {
            alterarDataFinal();
        }

        private void cb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            // nao aceita nenhum caractere
            e.Handled = true;
        }

        private void cb_hortalica_KeyPress(object sender, KeyPressEventArgs e)
        {
            // nao aceita numeros 
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_qtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // nao aceita letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
