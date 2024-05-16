using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin.FormsMenu
{
    public partial class FrmNewProduct : Form
    {
        public FrmNewProduct()
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
    }
}
