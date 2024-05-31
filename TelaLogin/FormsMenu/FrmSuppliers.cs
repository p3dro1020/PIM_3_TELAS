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
using TelaLogin.ClassGlobal;

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
            FrmPhoneSupplier frmPhoneSupplier = new FrmPhoneSupplier();
            string colName = dgv_suppliers.Columns[e.ColumnIndex].Name;
            var varId = dgv_suppliers.Rows[e.RowIndex].Cells[0].Value;
            if (colName == "cellphone")
            {
                frmPhoneSupplier.txt_fornecedorNome.Text = dgv_suppliers.Rows[e.RowIndex].Cells[2].Value.ToString();
                VarGlobal.id = Convert.ToInt32(varId);
                frmPhoneSupplier.ShowDialog();
            }
            else if (colName == "info")
            {
                MessageBox.Show("Lista todos os itens fornecidos");
            }

        }

        private void bt_addSuppliers_Click(object sender, EventArgs e)
        {
            FrmNewSupplier frmNewSupplier = new FrmNewSupplier();
            //ativa o botao adicionar / desativa o botao salvar / desativa o botao deletar
            frmNewSupplier.bt_save.Enabled = false;
            frmNewSupplier.bt_add.Enabled = true;
            frmNewSupplier.bt_delete.Enabled = false;
            //limpa todos os campos do formulario new supplier
            ClearFieldsNewSupplier();
            frmNewSupplier.ShowDialog();
            LoadSupplier();
        }


        // evento de duplo clique em uma celula do DGV
        private void dgv_suppliers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var varId = dgv_suppliers.Rows[e.RowIndex].Cells[0].Value;
                VarGlobal.id = int.Parse(varId.ToString());
                Fornecedor f = dbSupplier.SearchSupplier(VarGlobal.id);
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

                //ativa o botao adicionar / desativa o botao salvar / ativa o botao deletar
                frmNewSupplier.bt_save.Enabled = true;
                frmNewSupplier.bt_add.Enabled = false;
                frmNewSupplier.bt_delete.Enabled = true;
                frmNewSupplier.ShowDialog();
                LoadSupplier();
            }
        }

        private void bt_listAll_Click(object sender, EventArgs e)
        {
            LoadSupplier();
            txt_search.Clear();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            // verifica se o campo de pesquisa esta vazio
            if (txt_search.Text == "")
            {
                MessageBox.Show("Digite algo para pesquisar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // busca os fornecedores
            List<Fornecedor> fornecedor = dbSupplier.SearchSupplierName(txt_search.Text);

            // verifica se a lista de fornecedores esta vazia
            if (fornecedor.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSupplier();
                txt_search.Focus();
                return;
            }

            // limpa o datagridview
            dgv_suppliers.Rows.Clear();

            // insere os fornecedores no datagridview
            foreach (Fornecedor f in fornecedor)
            {
                dgv_suppliers.Rows.Add(f.Id, f.Cnpj, f.Nome, f.Email, f.DataCadastroFormatada);
            }
        }
    }
}
