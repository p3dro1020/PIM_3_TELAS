using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPIM
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
            dgv_suppliers.Rows.Add(001,"12.345.678/0001-00","Fornedor Y","fornecedor@gmail.com","(00) 12345-6789","21/05/2024");
        }
    }
}
