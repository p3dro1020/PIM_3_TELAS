using TelaLogin.FormsSubMenu;
using TelaLogin.Class;
using TelaLogin.Infra;

namespace TelaPIM
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            //Listar todos os funcionários
            List<Funcionario> funcionarios = new List<Funcionario>();
            DBemployee dbEmployee = new DBemployee();
            funcionarios = dbEmployee.ListAllEmployees();

            //Limpar o dgv
            dgv_employe.Rows.Clear();

            //Adicionar os funcionários no dgv
            foreach (Funcionario funcionario in funcionarios)
            {
                dgv_employe.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Cargo, funcionario.Email, funcionario.Salario, funcionario.Usuario, funcionario.Senha, funcionario.Acesso);
            }


        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            FrmNewEmployee newEmployee = new FrmNewEmployee();
            newEmployee.bt_add.Enabled = true;
            newEmployee.bt_save.Enabled = false;

            newEmployee.ShowDialog();
            LoadEmployees();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void dgv_employe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica se a coluna clicada foi a de edit
            if (dgv_employe.Columns[e.ColumnIndex].Name == "edit")
            {
                // pega o id do funcionário
                int id = Convert.ToInt32(dgv_employe.Rows[e.RowIndex].Cells["id"].Value);

                // busca o funcionário no banco
                DBemployee dbEmployee = new DBemployee();
                Funcionario funcionario = dbEmployee.SearchEmployee(id);

                // abre o form de cadastro de funcionário
                FrmNewEmployee newEmployee = new FrmNewEmployee();
                newEmployee.bt_add.Enabled = false;
                newEmployee.bt_save.Enabled = true;

                // preenche os campos do form
                newEmployee.txt_nome.Text = funcionario.Nome;
                newEmployee.txt_cargo.Text = funcionario.Cargo;
                newEmployee.txt_email.Text = funcionario.Email;
                newEmployee.txt_salario.Text = funcionario.Salario.ToString();
                newEmployee.txt_usuario.Text = funcionario.Usuario;
                newEmployee.txt_senha.Text = funcionario.Senha;
                newEmployee.txt_acesso.Text = funcionario.Acesso.ToString();
                newEmployee.id = funcionario.Id;

                newEmployee.ShowDialog();
                LoadEmployees();
            }
            else if (dgv_employe.Columns[e.ColumnIndex].Name == "delete")
            {
                // envia uma mensagem de confirmação
                DialogResult result = MessageBox.Show("Deseja realmente excluir este funcionário?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // pega o id do funcionário
                    int id = Convert.ToInt32(dgv_employe.Rows[e.RowIndex].Cells["id"].Value);

                    // busca o funcionário no banco
                    DBemployee dbEmployee = new DBemployee();
                    dbEmployee.DeleteEmployee(id);

                    LoadEmployees();
                }
            }


        }

        private void bt_listAll_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            txt_search.Clear();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            //verifica se o campo de pesquisa está vazio
            if (txt_search.Text == "")
            {
                MessageBox.Show("Digite algo para pesquisar");
                txt_search.Focus();
                return;
            }

            //Listar todos os funcionários
            List<Funcionario> funcionarios = new List<Funcionario>();
            DBemployee dbEmployee = new DBemployee();
            funcionarios = dbEmployee.SearchEmployeeName(txt_search.Text);

            //Limpar o dgv
            dgv_employe.Rows.Clear();

            //Adicionar os funcionários no dgv
            foreach (Funcionario funcionario in funcionarios)
            {
                dgv_employe.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Cargo, funcionario.Email, funcionario.Salario, funcionario.Usuario, funcionario.Senha, funcionario.Acesso);
            }

        }
    }
}
