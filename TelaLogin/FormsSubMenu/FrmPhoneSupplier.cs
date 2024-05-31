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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmPhoneSupplier : Form
    {
        public int id;

        private DBsupplier dbSupplier = new DBsupplier();

        private void LoadNums()
        {
            // limpa o list box
            lb_phone.Items.Clear();

            List<Fornecedor> numSuppliers = dbSupplier.SearchSupplierPhone(VarGlobal.id);

            foreach (Fornecedor numForn in numSuppliers)
            {
                lb_phone.Items.Add(numForn.Telefone);
            }
        }

        public FrmPhoneSupplier()
        {
            InitializeComponent();
        }

        private void FrmPhoneSupplier_Load(object sender, EventArgs e)
        {
            LoadNums();
        }

        private void lb_phone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_phone.SelectedItem != null)
            {
                txt_nums.Text = lb_phone.SelectedItem.ToString();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // verifica se o masked text box esta preenchido
            if (!txt_nums.MaskCompleted)
            {
                MessageBox.Show("Digite ou selecione um número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // verifica se o numero ja esta cadastrado
            foreach (var item in lb_phone.Items)
            {
                if (item.ToString() == txt_nums.Text)
                {
                    MessageBox.Show("Número já cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // adiciona o numero no list box
            lb_phone.Items.Add(txt_nums.Text);

            // adiciona o numero no banco de dados
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Id = VarGlobal.id;
            fornecedor.Telefone = txt_nums.Text;
            if (dbSupplier.AddNumSupplier(fornecedor))
            {
                MessageBox.Show("Número adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // limpa o masked text box
            txt_nums.Clear();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // verifica se o masked text box esta preenchido
            if (!txt_nums.MaskCompleted)
            {
                MessageBox.Show("Digite ou selecione um número para alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // verifica se o numero ja esta cadastrado
            foreach (var item in lb_phone.Items)
            {
                if (item.ToString() == txt_nums.Text)
                {
                    MessageBox.Show("Número já cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // verifica se um numero foi selecionado
            if (lb_phone.SelectedItem == null)
            {
                MessageBox.Show("Selecione um número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // adiciona o numero no list box
            lb_phone.Items.Add(txt_nums.Text);

            // adiciona o numero no banco de dados
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Id = VarGlobal.id;
            fornecedor.Telefone = txt_nums.Text;
            string numOld = lb_phone.SelectedItem.ToString();

            if (dbSupplier.UpdateNumSupplier(fornecedor, numOld))
            {
                MessageBox.Show("Número atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNums();
                txt_nums.Clear();
            }

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // verifica se um numero foi selecionado
            if (lb_phone.SelectedItem == null)
            {
                MessageBox.Show("Selecione um número para deletar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // enviar confirmação de exclusao
            DialogResult result = MessageBox.Show("Deseja realmente excluir o número?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // remove o numero do list box
                lb_phone.Items.Remove(lb_phone.SelectedItem);

                // remove o numero do banco de dados
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Id = VarGlobal.id;
                fornecedor.Telefone = txt_nums.Text;

                if (dbSupplier.DeleteNumSupplier(fornecedor))
                {
                    MessageBox.Show("Número excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNums();
                    txt_nums.Clear();
                }
            }
        }
    }
}
