using TelaLogin.Infra;
using TelaLogin.Class;

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
                dgv_history_sale.Rows.Add(item.IdPedido, item.DataVenda.ToString("dd/MM/yyyy"), item.Quantidade, "R$ " + item.Total);
            }

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
    }
}
