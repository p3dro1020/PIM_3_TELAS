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
using TelaLogin.ClassGlobal;
using TelaPIM;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmNewSupplier : Form
    {
        public FrmNewSupplier()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_cnpj.Text == "" || txt_razaoSocial.Text == "" || txt_email.Text == "" || txt_nomeFantasia.Text == "" || txt_cep.Text == "" || txt_endereco.Text == "" || txt_num.Text == "" || txt_bairro.Text == "" || txt_cidade.Text == "" || txt_uf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // instancia um novo fornecedor
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Cnpj = txt_cnpj.Text;
            fornecedor.RazaoSocial = txt_razaoSocial.Text;
            fornecedor.Email = txt_email.Text;
            fornecedor.Nome = txt_nomeFantasia.Text;
            fornecedor.Cep = txt_cep.Text;
            fornecedor.Endereco = txt_endereco.Text;
            fornecedor.Numero = int.Parse(txt_num.Text);
            fornecedor.Complemento = txt_complemento.Text;
            fornecedor.Bairro = txt_bairro.Text;
            fornecedor.Cidade = txt_cidade.Text;
            fornecedor.Uf = txt_uf.Text;

            // instancia a classe de banco de dados
            DBsupplier dbSupplier = new DBsupplier();
            // insere o fornecedor no banco de dados
            if (dbSupplier.CreateSuppliers(fornecedor))
            {
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                // limpa todos os campos do formulario new supplier
                txt_cnpj.Clear();
                txt_razaoSocial.Clear();
                txt_email.Clear();
                txt_nomeFantasia.Clear();
                txt_cep.Clear();
                txt_endereco.Clear();
                txt_num.Clear();
                txt_complemento.Clear();
                txt_bairro.Clear();
                txt_cidade.Clear();
                txt_uf.Text = "";
            }
            this.Close();

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            // verifica se preencheu todos os campos
            if (txt_cnpj.Text == "" || txt_razaoSocial.Text == "" || txt_email.Text == "" || txt_nomeFantasia.Text == "" || txt_cep.Text == "" || txt_endereco.Text == "" || txt_num.Text == "" || txt_bairro.Text == "" || txt_cidade.Text == "" || txt_uf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            Fornecedor fornecedor = new Fornecedor();
            DBsupplier dbSupplier = new DBsupplier();
            fornecedor = dbSupplier.SearchSupplier(VarGlobal.id);

            // verifica se algum dado foi realmente alterado
            if (txt_cnpj.Text == fornecedor.Cnpj && txt_razaoSocial.Text == fornecedor.RazaoSocial && txt_email.Text == fornecedor.Email && txt_nomeFantasia.Text == fornecedor.Nome && txt_cep.Text == fornecedor.Cep && txt_endereco.Text == fornecedor.Endereco && txt_num.Text == fornecedor.Numero.ToString() && txt_complemento.Text == fornecedor.Complemento && txt_bairro.Text == fornecedor.Bairro && txt_cidade.Text == fornecedor.Cidade && txt_uf.Text == fornecedor.Uf)
            {
                MessageBox.Show("Nenhum dado foi alterado!");
                return;
            }

            // instancia um novo fornecedor
            fornecedor.Cnpj = txt_cnpj.Text;
            fornecedor.RazaoSocial = txt_razaoSocial.Text;
            fornecedor.Email = txt_email.Text;
            fornecedor.Nome = txt_nomeFantasia.Text;
            fornecedor.Cep = txt_cep.Text;
            fornecedor.Endereco = txt_endereco.Text;
            fornecedor.Numero = int.Parse(txt_num.Text);
            fornecedor.Complemento = txt_complemento.Text;
            fornecedor.Bairro = txt_bairro.Text;
            fornecedor.Cidade = txt_cidade.Text;
            fornecedor.Uf = txt_uf.Text;

            // atualiza o fornecedor no banco de dados
            if (dbSupplier.UpdateSuppliers(fornecedor))
            {
                MessageBox.Show("Fornecedor atualizado com sucesso!");
                this.Close();
            }

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // confirma se deseja realmente excluir o fornecedor
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o fornecedor?", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DBsupplier dbSupplier = new DBsupplier();
                // exclui o fornecedor do banco de dados
                if (dbSupplier.DeleteSuppliers(VarGlobal.id))
                {
                    MessageBox.Show("Fornecedor excluído com sucesso!");
                    this.Close();
                }
            }
        }
    }
}
