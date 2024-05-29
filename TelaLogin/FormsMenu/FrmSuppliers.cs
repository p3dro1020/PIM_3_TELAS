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
using TelaLogin.FormsMenu;
using TelaLogin.FormsSubMenu;
using TelaLogin.Infra;

namespace TelaPIM
{
    public partial class FrmSuppliers : Form
    {
        private DBsupplier dbSupplier = new DBsupplier();
        public FrmSuppliers()
        {
            InitializeComponent();
            LoadSupplier();
        }

        private void ClearFieldsNewSupplier()
        {
            FrmNewSupplier frmNewSupplier = new FrmNewSupplier();
            // limpa todos os campos do formulario new supplier
            frmNewSupplier.txt_cnpj.Clear();
            frmNewSupplier.txt_razaoSocial.Clear();
            frmNewSupplier.txt_email.Clear();
            frmNewSupplier.txt_nomeFantasia.Clear();
            frmNewSupplier.txt_cep.Clear();
            frmNewSupplier.txt_endereco.Clear();
            frmNewSupplier.txt_num.Clear();
            frmNewSupplier.txt_complemento.Clear();
            frmNewSupplier.txt_bairro.Clear();
            frmNewSupplier.txt_cidade.Clear();
            frmNewSupplier.txt_uf.Text = "";

        }

        private void LoadSupplier()
        {

            dgv_suppliers.Rows.Clear();
            List<Fornecedor> fornecedor = dbSupplier.ListAllSuppliers();

            // insere os produtos no datagridview
            foreach (Fornecedor f in fornecedor)
            {
                dgv_suppliers.Rows.Add(f.Id, f.Cnpj, f.Nome, f.Email, f.DataCadastroFormatada);
            }

        }

        private void dgv_suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string colName = dgv_suppliers.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FrmProductManagement frmProductManagement = new FrmProductManagement();
                frmProductManagement.bt_save.Enabled = true;
                frmProductManagement.bt_addNewPlantio.Enabled = false;
                frmProductManagement.cb_hortalica.Text = dgv_suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmProductManagement.txt_qtd.Text = dgv_suppliers.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmProductManagement.dt_plantio.Text = Convert.ToDateTime(dgv_suppliers.Rows[e.RowIndex].Cells[3].Value).ToString();
                frmProductManagement.id = Convert.ToInt32(dgv_suppliers.Rows[e.RowIndex].Cells["cod"].Value);
                frmProductManagement.ShowDialog();
                // recarrega o datagridview
                LoadProduct();
            }
            else if (colName == "Delete")
            {
                // confirma se o usuario deseja excluir
                DialogResult res = MessageBox.Show("Deseja realmente remover o produto?", "Remover", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    // pega o id do produto
                    int id = Convert.ToInt32(dgv_Production.Rows[e.RowIndex].Cells["cod"].Value);
                    // exclui o produto
                    db.ExcludeProduct(id);
                    // recarrega o datagridview
                    LoadProduct();
                }
            }
            */
        }

        private void bt_addSuppliers_Click(object sender, EventArgs e)
        {
            FrmNewSupplier frmNewSupplier = new FrmNewSupplier();
            //ativa o botao adicionar e desativa o botao salvar
            frmNewSupplier.bt_save.Enabled = false;
            frmNewSupplier.bt_add.Enabled = true;
            //limpa todos os campos do formulario new supplier
            ClearFieldsNewSupplier();
            frmNewSupplier.ShowDialog();
        }


        // evento de duplo clique em uma celula do DGV
        private void dgv_suppliers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var varId = dgv_suppliers.Rows[e.RowIndex].Cells[0].Value;
                int.TryParse(varId.ToString(), out int id);
                Fornecedor f = dbSupplier.SearchSupplier(id);
                if (f == null) return;


                FrmNewSupplier frmNewSupplier = new FrmNewSupplier();
                frmNewSupplier.txt_cnpj.Text = f.Cnpj;
                frmNewSupplier.txt_razaoSocial.Text = f.RazaoSocial;
                frmNewSupplier.txt_email.Text = f.Email;
                frmNewSupplier.txt_nomeFantasia.Text = f.Nome;
                frmNewSupplier.txt_cep.Text = f.Cep;
                frmNewSupplier.txt_endereco.Text = f.Endereco;
                frmNewSupplier.txt_num.Text = f.Numero.ToString();
                frmNewSupplier.txt_complemento.Text = f.Complemento;
                frmNewSupplier.txt_bairro.Text = f.Bairro;
                frmNewSupplier.txt_cidade.Text = f.Cidade;
                frmNewSupplier.txt_uf.Text = f.Uf;

                //ativa o botao adicionar e desativa o botao salvar
                frmNewSupplier.bt_save.Enabled = true;
                frmNewSupplier.bt_add.Enabled = false;
                frmNewSupplier.ShowDialog();
            }
        }
    }
}
