using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.Infra;
using TelaLogin.Class;
using TelaLogin.ClassGlobal;

namespace TelaLogin.FormsSubMenu
{
    public partial class FrmAlterItem : Form
    {
        public string nome;
        public string un;
        public string preco;
        DBsupplier dbSupplier = new DBsupplier();

        public FrmAlterItem()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_nomeItem.Text == "" || txt_preco.Text == "" || txt_un.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Item item = new Item();
            item.NomeItem = txt_nomeItem.Text;
            item.Id_fornecedor = VarGlobal.id;
            item.Un = txt_un.Text;
            item.Preco = Convert.ToDouble(txt_preco.Text);


            if (dbSupplier.AddNewItem(item))
            {
                MessageBox.Show("Item adicionado com sucesso!");
                this.Close();
            }

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // verifica se todos os campos foram preenchidos
            if (txt_nomeItem.Text == "" || txt_preco.Text == "" || txt_un.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // verifica se algum dado foi alterado
            if (nome == txt_nomeItem.Text && un == txt_un.Text && preco == txt_preco.Text)
            {
                MessageBox.Show("Nenhum dado foi alterado!");
                return;
            }

            Item item = new Item();
            item.NomeItem = txt_nomeItem.Text;
            item.Id_fornecedor = VarGlobal.id;
            item.Un = txt_un.Text;
            item.Preco = Convert.ToDouble(txt_preco.Text);

            if(dbSupplier.UpdateItem(item))
            {
                MessageBox.Show("Item alterado com sucesso");
                this.Close();
            }

        }
    }
}
