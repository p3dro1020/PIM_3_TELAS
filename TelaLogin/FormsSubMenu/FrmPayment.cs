using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;
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
            txt_valorFinal.Text = txt_valor_total.Text;
            VarGlobal.Sucesso = 0;
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

        public void GerarCupomNaoFiscal(List<Item> produtos)
        {
            string caminhoArquivo = "C:\\PDFCupomNaoFiscal.pdf";
            Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            FileStream arquivoPDF = new FileStream(caminhoArquivo, FileMode.Create);
            PdfWriter writer = PdfWriter.GetInstance(doc, arquivoPDF);

            doc.Open();

            // Gera o cupom não fiscal
            Paragraph paragrafo = new Paragraph("********** CUPOM NÃO FISCAL **********\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragrafo);

            paragrafo = new Paragraph("---------------------------------------\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragrafo);

            paragrafo = new Paragraph("Data: " + DateTime.Now + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragrafo);

            paragrafo = new Paragraph("---------------------------------------\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragrafo);

            // Cabeçalho da Tabela
            PdfPTable table = new PdfPTable(4); // Adicionado uma coluna extra para o Valor Total
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 50, 15, 15, 20 });

            PdfPCell cell = new PdfPCell(new Phrase("Nome do Produto", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold)));
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Quantidade", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold)));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Valor Unitário", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold)));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Valor Total", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold)));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            // Itens
            foreach (Item produto in produtos)
            {
                cell = new PdfPCell(new Phrase(produto.NomeItem, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular)));
                cell.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(produto.Quantidade.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(produto.PrecoVenda.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);


                double valorTotal = Convert.ToDouble(produto.Quantidade) * produto.PrecoVenda;
                cell = new PdfPCell(new Phrase(valorTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            doc.Add(table);

            paragrafo = new Paragraph("---------------------------------------\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragrafo);

            string dados = $"Total: {produtos.Sum(p => p.ValorTotalItem).ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}\n";
            paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragrafo);

            paragrafo = new Paragraph("***************************************\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragrafo);

            doc.Close();

        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (cb_pagamento.Text == "" || txt_desconto.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pedido p = new Pedido();
            p.Total = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", ""));
            p.Desconto = Convert.ToDouble(txt_desconto.Text.Replace("R$ ", ""));
            p.Pagamento = cb_pagamento.Text;
            p.Quantidade = VarGlobal.Qtd;

            DBpedido dbPedido = new DBpedido();
            if (dbPedido.AddNewPedido(p))
            {
                MessageBox.Show("Venda realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // diminui a quantidade de itens no estoque
                DBstock dbItem = new DBstock();
                foreach (Item i in Items)
                {
                    dbItem.UpdateStockSale(i);
                } 

                VarGlobal.Sucesso = 1;
                Pedido pd = dbPedido.GetProxPedido();
                int idPedido = pd.IdPedido;
                // insere os itens do pedido no banco de dados          
                foreach (Item i in Items)
                {
                    i.IdPedido = idPedido;
                    dbPedido.AddItemPedido(i);
                }

                GerarCupomNaoFiscal(Items);

                this.Close();
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



            // verifica se a opção selecionada foi a de cartao 2x
            if (cb_pagamento.Text == "Cartão crédito 2x.")
            {
                double valor = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", "")) * 1.02 - Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", ""));
                txt_acrescimo.Text = $"R$ {valor.ToString("0.00")}";
            }
            else if (cb_pagamento.Text == "Cartão crédito 3x.")
            {
                double valor = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", "")) * 1.03 - Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", ""));
                txt_acrescimo.Text = $"R$ {valor.ToString("0.00")}";
            }
            else
            {
                txt_acrescimo.Text = "R$ 00,00";
            }
        }

        private void txt_acrescimo_TextChanged(object sender, EventArgs e)
        {
            // verifica se o valor é diferente de 0
            if (txt_acrescimo.Text != "R$ 00,00")
            {
                // calcula o valor total
                double valor = Convert.ToDouble(txt_valor_total.Text.Replace("R$ ", "")) + Convert.ToDouble(txt_acrescimo.Text.Replace("R$ ", ""));
                txt_valorFinal.Text = $"R$ {valor.ToString("0.00")}";
            }
        }
    }
}
