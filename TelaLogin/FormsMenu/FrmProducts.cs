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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            dgv_products.Rows.Add(001,"Alface",400,"R$ 5.00","R$ "+400*5,"Fazenda X","01/06/2024");
        }
    }
}
