namespace TelaLogin.FormsSubMenu
{
    partial class FrmItemsProvided
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
            label1 = new Label();
            dgv_itens_fornecidos = new DataGridView();
            cod = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            name_item = new DataGridViewTextBoxColumn();
            unity = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            txt_fornecedor_name = new Label();
            bt_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_itens_fornecidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Fornecedor:";
            // 
            // dgv_itens_fornecidos
            // 
            dgv_itens_fornecidos.AllowUserToAddRows = false;
            dgv_itens_fornecidos.BackgroundColor = Color.White;
            dgv_itens_fornecidos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Sienna;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_itens_fornecidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_itens_fornecidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_itens_fornecidos.Columns.AddRange(new DataGridViewColumn[] { cod, name, name_item, unity, preco });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_itens_fornecidos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_itens_fornecidos.EnableHeadersVisualStyles = false;
            dgv_itens_fornecidos.GridColor = SystemColors.GrayText;
            dgv_itens_fornecidos.Location = new Point(29, 69);
            dgv_itens_fornecidos.Name = "dgv_itens_fornecidos";
            dgv_itens_fornecidos.ReadOnly = true;
            dgv_itens_fornecidos.RowHeadersVisible = false;
            dgv_itens_fornecidos.Size = new Size(725, 284);
            dgv_itens_fornecidos.TabIndex = 1;
            dgv_itens_fornecidos.CellMouseDoubleClick += dgv_itens_fornecidos_CellMouseDoubleClick;
            // 
            // cod
            // 
            cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod.HeaderText = "Cód. Fornecedor";
            cod.Name = "cod";
            cod.ReadOnly = true;
            cod.Width = 113;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nome fornecedor";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // name_item
            // 
            name_item.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name_item.HeaderText = "Nome item";
            name_item.Name = "name_item";
            name_item.ReadOnly = true;
            name_item.Width = 88;
            // 
            // unity
            // 
            unity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            unity.HeaderText = "Unidade";
            unity.Name = "unity";
            unity.ReadOnly = true;
            unity.Width = 78;
            // 
            // preco
            // 
            preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            preco.Width = 64;
            // 
            // txt_fornecedor_name
            // 
            txt_fornecedor_name.AutoSize = true;
            txt_fornecedor_name.Location = new Point(105, 29);
            txt_fornecedor_name.Name = "txt_fornecedor_name";
            txt_fornecedor_name.Size = new Size(0, 15);
            txt_fornecedor_name.TabIndex = 2;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(679, 29);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 3;
            bt_add.Text = "Novo";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // FrmItemsProvided
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_add);
            Controls.Add(txt_fornecedor_name);
            Controls.Add(dgv_itens_fornecidos);
            Controls.Add(label1);
            Name = "FrmItemsProvided";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Itens fornecidos";
            Load += FrmItemsProvided_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_itens_fornecidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_itens_fornecidos;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn name_item;
        private DataGridViewTextBoxColumn unity;
        private DataGridViewTextBoxColumn preco;
        public Label txt_fornecedor_name;
        private Button bt_add;
    }
}