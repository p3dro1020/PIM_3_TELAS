using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.FormsMenu;
using TelaLogin.FormsSubMenu;

namespace TelaPIM
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
            dgv_suppliers.Rows.Add(001, "12.345.678/0001-00", "Fornedor Y", "fornecedor@gmail.com", "(00) 12345-6789", "21/05/2024");
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
            frmNewSupplier.bt_save.Enabled = false;
            frmNewSupplier.bt_add.Enabled = true;
            frmNewSupplier.ShowDialog();
        }
    }
}
