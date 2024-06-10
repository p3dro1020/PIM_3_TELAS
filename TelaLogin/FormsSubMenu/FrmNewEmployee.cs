using Npgsql.PostgresTypes;
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

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmNewEmployee : Form
    {
        public int id;
        public FrmNewEmployee()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_nome.Text == "" || txt_email.Text == "" || txt_senha.Text == "" || txt_acesso.Text == "" || txt_cpf.Text == "" || txt_email.Text == "" || txt_usuario.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // cria um objeto funcionário
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txt_nome.Text;
            funcionario.Cargo = txt_cargo.Text;
            funcionario.Cpf = txt_cpf.Text;
            funcionario.Email = txt_email.Text;
            funcionario.Salario = Convert.ToDouble(txt_salario.Text);
            funcionario.Usuario = txt_usuario.Text;
            funcionario.Senha = txt_senha.Text;
            funcionario.Acesso = Convert.ToInt32(txt_acesso.Text);

            // insere o funcionário no banco
            DBemployee dbEmployee = new DBemployee();
            if (dbEmployee.CreateEmployee(funcionario))
            {
                //envia um aviso de confirmação
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                this.Close();
                return;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_nome.Text == "" || txt_email.Text == "" || txt_senha.Text == "" || txt_acesso.Text == "" || txt_cpf.Text == "" || txt_email.Text == "" || txt_usuario.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // cria um objeto funcionário
            Funcionario funcionario = new Funcionario();
            funcionario.Id = id;
            funcionario.Nome = txt_nome.Text;
            funcionario.Cargo = txt_cargo.Text;
            funcionario.Cpf = txt_cpf.Text;
            funcionario.Email = txt_email.Text;
            funcionario.Salario = Convert.ToDouble(txt_salario.Text);
            funcionario.Usuario = txt_usuario.Text;
            funcionario.Senha = txt_senha.Text;
            funcionario.Acesso = Convert.ToInt32(txt_acesso.Text);

            // atualiza o funcionário no banco
            DBemployee dbEmployee = new DBemployee();
            if (dbEmployee.UpdateEmployee(funcionario))
            {
                //envia um aviso de confirmação
                MessageBox.Show("Funcionário atualizado com sucesso!");
                this.Close();
                return;
            }

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
