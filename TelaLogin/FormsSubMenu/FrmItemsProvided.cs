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
            if(VarGlobal.id == 0)
            {
                MessageBox.Show("Selecione um fornecedor!");
                return;
            }

            if(VarGlobal.nome == "N/A")
            {
                // limpa o dgv
                dgv_itens_fornecidos.Rows.Clear();
                List<Item> items = dbSupplier.SearchSupplierItemName(VarGlobal.nome);

                // insere os itens no datagridview
                foreach (Item i in items)
                {
                    dgv_itens_fornecidos.Rows.Add(i.Categoria, i.IdItem, i.CodigoBarras, i.NomeItem, i.Un, i.PrecoCusto, i.PrecoVenda, i.Lucro);
                }

                return;
            }


            // limpa o dgv
            dgv_itens_fornecidos.Rows.Clear();
            List<Item> item = dbSupplier.SearchSupplierItem(VarGlobal.id);

            // insere os itens no datagridview
            foreach (Item i in item)
            {
                dgv_itens_fornecidos.Rows.Add(i.Categoria, i.IdItem, i.CodigoBarras,i.NomeItem, i.Un,i.PrecoCusto ,i.PrecoVenda,i.Lucro);
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
                Item i = new Item();
                VarGlobal.id_item = Convert.ToInt32(dgv_itens_fornecidos.Rows[e.RowIndex].Cells[1].Value);
                 i = dbSupplier.SearchItem(VarGlobal.id_item);

                if (i == null) return;

                FrmAlterItem frmAlterItem = new FrmAlterItem();
                frmAlterItem.txt_codigo_barras.Text = i.CodigoBarras;
                frmAlterItem.txt_nome.Text = i.NomeItem;
                frmAlterItem.cb_un.Text = i.Un;
                frmAlterItem.txt_preco_custo.Text = i.PrecoCusto.ToString();
                frmAlterItem.txt_porcentagem.Text = i.Porcentagem.ToString();
                frmAlterItem.txt_valor_venda.Text = i.PrecoVenda.ToString();
                frmAlterItem.txt_lucro.Text = i.Lucro.ToString();
                frmAlterItem.txt_categoria.Text = i.Categoria;
                frmAlterItem.txt_estoque_minimo.Text = i.EstoqueMinimo.ToString();
                frmAlterItem.txt_fornecedor.Text = VarGlobal.nome;

                
                

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
            // limpa todos os txt do formulario de alterar item
            frmAlterItem.txt_codigo_barras.Text = "";
            frmAlterItem.txt_nome.Text = "";
            frmAlterItem.cb_un.Text = "";
            frmAlterItem.txt_preco_custo.Text = "";
            frmAlterItem.txt_porcentagem.Text = "";
            frmAlterItem.txt_valor_venda.Text = "";
            frmAlterItem.txt_lucro.Text = "";
            frmAlterItem.txt_categoria.Text = "";
            frmAlterItem.txt_estoque_minimo.Text = "";
            frmAlterItem.txt_fornecedor.Text = VarGlobal.nome;

            //ativa o botao adicionar / desativa o botao salvar / ativa o botao deletar
            frmAlterItem.bt_save.Enabled = false;
            frmAlterItem.bt_delete.Enabled = false;
            frmAlterItem.bt_add.Enabled = true;
            frmAlterItem.ShowDialog();
            LoadItens();

        }
    }
}
