namespace TelaLogin.FormsSubMenu
{
    partial class FrmSaleDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleDetails));
            label1 = new Label();
            txt_id_pedido = new TextBox();
            label2 = new Label();
            txt_data = new TextBox();
            txt_total = new TextBox();
            label3 = new Label();
            txt_qtd = new TextBox();
            label4 = new Label();
            dgv_history_itens = new DataGridView();
            qtd = new DataGridViewTextBoxColumn();
            id_produto = new DataGridViewTextBoxColumn();
            un = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            qtd_item = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            lucro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_history_itens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Código venda:";
            // 
            // txt_id_pedido
            // 
            txt_id_pedido.Enabled = false;
            txt_id_pedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_id_pedido.Location = new Point(128, 46);
            txt_id_pedido.Name = "txt_id_pedido";
            txt_id_pedido.Size = new Size(37, 23);
            txt_id_pedido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Data venda:";
            // 
            // txt_data
            // 
            txt_data.Enabled = false;
            txt_data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_data.Location = new Point(262, 46);
            txt_data.Name = "txt_data";
            txt_data.Size = new Size(98, 23);
            txt_data.TabIndex = 3;
            // 
            // txt_total
            // 
            txt_total.Enabled = false;
            txt_total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_total.Location = new Point(443, 46);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(98, 23);
            txt_total.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 49);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor total:";
            // 
            // txt_qtd
            // 
            txt_qtd.Enabled = false;
            txt_qtd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_qtd.Location = new Point(624, 46);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(37, 23);
            txt_qtd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 49);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Qtd itens:";
            // 
            // dgv_history_itens
            // 
            dgv_history_itens.AllowUserToAddRows = false;
            dgv_history_itens.BackgroundColor = Color.White;
            dgv_history_itens.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_history_itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_history_itens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history_itens.Columns.AddRange(new DataGridViewColumn[] { qtd, id_produto, un, name, valor, qtd_item, total, lucro });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_history_itens.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_history_itens.Location = new Point(38, 115);
            dgv_history_itens.Name = "dgv_history_itens";
            dgv_history_itens.RowHeadersVisible = false;
            dgv_history_itens.Size = new Size(759, 321);
            dgv_history_itens.TabIndex = 8;
            // 
            // qtd
            // 
            qtd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd.HeaderText = "Qtd. Itens";
            qtd.Name = "qtd";
            qtd.Width = 83;
            // 
            // id_produto
            // 
            id_produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id_produto.HeaderText = "Cód. Produto";
            id_produto.Name = "id_produto";
            id_produto.Width = 95;
            // 
            // un
            // 
            un.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            un.HeaderText = "Unidade";
            un.Name = "un";
            un.Width = 76;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nome";
            name.Name = "name";
            // 
            // valor
            // 
            valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valor.HeaderText = "Valor UN R$";
            valor.Name = "valor";
            valor.Width = 75;
            // 
            // qtd_item
            // 
            qtd_item.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd_item.HeaderText = "Quantidade";
            qtd_item.Name = "qtd_item";
            qtd_item.Width = 94;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            total.HeaderText = "Total pago R$";
            total.Name = "total";
            total.Width = 83;
            // 
            // lucro
            // 
            lucro.HeaderText = "Ganhos R$";
            lucro.Name = "lucro";
            // 
            // FrmSaleDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 492);
            Controls.Add(dgv_history_itens);
            Controls.Add(txt_qtd);
            Controls.Add(label4);
            Controls.Add(txt_total);
            Controls.Add(label3);
            Controls.Add(txt_data);
            Controls.Add(label2);
            Controls.Add(txt_id_pedido);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSaleDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes venda";
            Load += FrmSaleDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_history_itens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgv_history_itens;
        public TextBox txt_id_pedido;
        public TextBox txt_data;
        public TextBox txt_total;
        public TextBox txt_qtd;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn id_produto;
        private DataGridViewTextBoxColumn un;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn qtd_item;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn lucro;
    }
}