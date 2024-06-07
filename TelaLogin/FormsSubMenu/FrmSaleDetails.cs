using TelaLogin.Infra;
using TelaLogin.Class;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmSaleDetails : Form
    {
        public FrmSaleDetails()
        {
            InitializeComponent();
        }

        private void LoadItems()
        {
            DBsale dBsale = new DBsale();
            List<Venda> v = new List<Venda>();
            v = dBsale.SearchItensSale(Convert.ToInt32(txt_id_pedido.Text));
            int i = 1;
            foreach (Venda item in v)
            {
                dgv_history_itens.Rows.Add(i,item.CodigoProduto, item.Unidade,item.Produto,"R$ "+ item.ValorUnitario.ToString("0.00"),item.Quantidade, "R$ " + (item.ValorUnitario * item.Quantidade).ToString("0.00"), "R$ " + item.Ganhos);
                i++;
            }
        }

        private void FrmSaleDetails_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
    }
}
