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
using TelaLogin.ClassGlobal;
using TelaLogin.Infra;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmItemsProvided : Form
    {
        DBsupplier dbSupplier = new DBsupplier();
        public FrmItemsProvided()
        {
            InitializeComponent();
        }

        private void LoadItens()
        {
            // limpa o dgv
            dgv_itens_fornecidos.Rows.Clear();
            List<Item> item = dbSupplier.SearchSupplierItem(VarGlobal.id);

            // insere os itens no datagridview
            foreach (Item i in item)
            {
                dgv_itens_fornecidos.Rows.Add(VarGlobal.id, VarGlobal.nome, i.NomeItem, i.Un, i.Preco);
            }

        }

        private void FrmItemsProvided_Load(object sender, EventArgs e)
        {
            LoadItens();
        }

        private void dgv_itens_fornecidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var varId = dgv_itens_fornecidos.Rows[e.RowIndex].Cells[0].Value;
                Item i = new Item();
                i.NomeItem = dgv_itens_fornecidos.Rows[e.RowIndex].Cells[2].Value.ToString();
                i.Un = dgv_itens_fornecidos.Rows[e.RowIndex].Cells[3].Value.ToString();
                i.Preco = Convert.ToDouble(dgv_itens_fornecidos.Rows[e.RowIndex].Cells[4].Value);

                if (i == null) return;

                FrmAlterItem frmAlterItem = new FrmAlterItem();
                frmAlterItem.txt_nomeItem.Text = i.NomeItem;
                frmAlterItem.txt_un.Text = i.Un;
                frmAlterItem.txt_preco.Text = i.Preco.ToString();
                frmAlterItem.nome = i.NomeItem;
                frmAlterItem.un = i.Un;
                frmAlterItem.preco = i.Preco.ToString();


                //ativa o botao adicionar / desativa o botao salvar / ativa o botao deletar
                frmAlterItem.bt_save.Enabled = true;
                frmAlterItem.bt_delete.Enabled = true;
                frmAlterItem.bt_add.Enabled = false;
                frmAlterItem.ShowDialog();
                LoadItens();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            FrmAlterItem frmAlterItem = new FrmAlterItem();
            frmAlterItem.txt_nomeItem.Text = "";
            frmAlterItem.txt_un.Text = "";
            frmAlterItem.txt_preco.Text = "";


            //ativa o botao adicionar / desativa o botao salvar / ativa o botao deletar
            frmAlterItem.bt_save.Enabled = false;
            frmAlterItem.bt_delete.Enabled = false;
            frmAlterItem.bt_add.Enabled = true;
            frmAlterItem.ShowDialog();
            LoadItens();

        }
    }
}
