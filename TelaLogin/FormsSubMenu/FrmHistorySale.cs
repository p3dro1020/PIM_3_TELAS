using TelaLogin.Infra;
using TelaLogin.Class;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmHistorySale : Form
    {
        public FrmHistorySale()
        {
            InitializeComponent();
        }

        private void LoadSales()
        {
            DBsale dBsale = new DBsale();
            List<Pedido> p = new List<Pedido>();
            p = dBsale.SearchSales();


            foreach (Pedido item in p)
            {
                dgv_history_sale.Rows.Add(item.IdPedido, item.DataVenda.ToString("dd/MM/yyyy"), item.Pagamento, item.Quantidade, "R$ " + item.Total);
            }
            SomaFaturamento();
        }

        private void SomaFaturamento()
        {
            // verifica se o dgv esta vazio
            if (dgv_history_sale.Rows.Count == 0)
            {
                txt_faturamento.Text = "R$ 0,00";
                return;
            }

            // verifica se a data fim é maior que a data inicio
            if (data_inicio.Value > data_fim.Value)
            {
                return;
            }


            // soma todas as linhas do dgv do campo valor total
            decimal total = 0;
            for (int i = 0; i < dgv_history_sale.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgv_history_sale.Rows[i].Cells["total"].Value.ToString().Replace("R$ ", ""));
            }
            txt_faturamento.Text = "R$ " + total.ToString();
        }

        private void FrmHistorySale_Load(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void dgv_history_sale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica se a coluna clicada foi a de info
            if (e.ColumnIndex == dgv_history_sale.Columns["info"].Index)
            {
                // instancia o form de detalhes
                FrmSaleDetails frmSaleDetails = new FrmSaleDetails();
                frmSaleDetails.txt_id_pedido.Text = dgv_history_sale.Rows[e.RowIndex].Cells["id_pedido"].Value.ToString();
                frmSaleDetails.txt_data.Text = dgv_history_sale.Rows[e.RowIndex].Cells["date"].Value.ToString();
                frmSaleDetails.txt_qtd.Text = dgv_history_sale.Rows[e.RowIndex].Cells["qtd"].Value.ToString();
                frmSaleDetails.txt_total.Text = "R$ " + dgv_history_sale.Rows[e.RowIndex].Cells["total"].Value.ToString();

                frmSaleDetails.ShowDialog();
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            // verifica se a data fim é maior que a data inicio
            if (data_inicio.Value > data_fim.Value)
            {
                MessageBox.Show("Data fim não pode ser menor que a data inicio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // pesquisa as vendas por data
            DBsale dBsale = new DBsale();
            List<Pedido> p = new List<Pedido>();
            p = dBsale.SearchSalesByDate(data_inicio.Value, data_fim.Value);

            // limpa o dgv
            dgv_history_sale.Rows.Clear();

            // insere as vendas no dgv
            foreach (Pedido item in p)
            {
                dgv_history_sale.Rows.Add(item.IdPedido, item.DataVenda.ToString("dd/MM/yyyy"), item.Pagamento, item.Quantidade, "R$ " + item.Total);
            }

        }

        private void bt_listAll_Click(object sender, EventArgs e)
        {
            LoadSales(); 
            // ajusta as datas para data de inicio = 01/01/2024 e fim a data atual
            data_inicio.Value = new DateTime(2024, 1, 1);
            data_fim.Value = DateTime.Now;
        }

        private void bt_relatorio_Click(object sender, EventArgs e)
        {
            // verifica se o dgv esta vazio
            if (dgv_history_sale.Rows.Count == 0)
            {
                MessageBox.Show("Não há vendas para gerar relatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GerarRelatorio(data_inicio.Value.ToString("dd/MM/yyyy"), data_fim.Value.ToString("dd/MM/yyyy"));

        }

        public void GerarRelatorio(string dataInicial, string dataFinal)
        {
            // Cria o documento PDF
            Document doc = new Document();
            string dataAtual = DateTime.Now.ToString("dd-MM-yyyy");
            string nomeArquivo = @"C:\PDF\RelatorioVendas_" + dataAtual + ".pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            PdfWriter writer = PdfWriter.GetInstance(doc, arquivoPDF);

            doc.Open();

            // Adiciona a data de pesquisa e a data de emissão ao relatório
            Paragraph paragrafo = new Paragraph($"Data de Pesquisa: {dataInicial} - {dataFinal}\n");
            doc.Add(paragrafo);

            paragrafo = new Paragraph($"Data de Emissão: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}\n\n");
            doc.Add(paragrafo);

            // Adiciona a tabela de vendas ao relatório
            PdfPTable table = new PdfPTable(dgv_history_sale.Columns.Count - 1); // Excluindo a última coluna
            table.WidthPercentage = 100;

            // Adiciona os cabeçalhos das colunas (exceto a última)
            foreach (DataGridViewColumn column in dgv_history_sale.Columns)
            {
                if (column.Index != dgv_history_sale.Columns.Count - 1) // Verifica se não é a última coluna
                    table.AddCell(column.HeaderText);
            }

            // Adiciona os dados das vendas (exceto a última coluna)
            foreach (DataGridViewRow row in dgv_history_sale.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex != dgv_history_sale.Columns.Count - 1) // Verifica se não é a última coluna
                        table.AddCell(cell.Value.ToString());
                }
            }

            doc.Add(table);

            paragrafo = new Paragraph($"\n\nValor total: {txt_faturamento.Text}");
            doc.Add(paragrafo);

            doc.Close();

            MessageBox.Show("Relatório de vendas gerado com sucesso!");
        }

        private void data_fim_ValueChanged(object sender, EventArgs e)
        {
            // verifica se a data fim é maior que a data inicio
            if (data_inicio.Value > data_fim.Value)
            {
                MessageBox.Show("Data fim não pode ser menor que a data inicio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // pesquisa as vendas por data
            DBsale dBsale = new DBsale();
            List<Pedido> p = new List<Pedido>();
            p = dBsale.SearchSalesByDate(data_inicio.Value, data_fim.Value);

            // limpa o dgv
            dgv_history_sale.Rows.Clear();

            // insere as vendas no dgv
            foreach (Pedido item in p)
            {
                dgv_history_sale.Rows.Add(item.IdPedido, item.DataVenda.ToString("dd/MM/yyyy"), item.Pagamento, item.Quantidade, "R$ " + item.Total);
            }
            SomaFaturamento();
        }

        private void data_inicio_ValueChanged(object sender, EventArgs e)
        {
            // verifica se a data fim é maior que a data inicio
            if (data_inicio.Value > data_fim.Value)
            {
                MessageBox.Show("Data fim não pode ser menor que a data inicio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // pesquisa as vendas por data
            DBsale dBsale = new DBsale();
            List<Pedido> p = new List<Pedido>();
            p = dBsale.SearchSalesByDate(data_inicio.Value, data_fim.Value);

            // limpa o dgv
            dgv_history_sale.Rows.Clear();

            // insere as vendas no dgv
            foreach (Pedido item in p)
            {
                dgv_history_sale.Rows.Add(item.IdPedido, item.DataVenda.ToString("dd/MM/yyyy"), item.Pagamento, item.Quantidade, "R$ " + item.Total);
            }
            SomaFaturamento();
        }
    }
}
