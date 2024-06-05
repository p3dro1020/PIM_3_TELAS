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
            category = new DataGridViewTextBoxColumn();
            id_item = new DataGridViewTextBoxColumn();
            cod_barras = new DataGridViewTextBoxColumn();
            name_item = new DataGridViewTextBoxColumn();
            unity = new DataGridViewTextBoxColumn();
            custo = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            lucro = new DataGridViewTextBoxColumn();
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
            dgv_itens_fornecidos.Columns.AddRange(new DataGridViewColumn[] { category, id_item, cod_barras, name_item, unity, custo, preco, lucro });
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
            dgv_itens_fornecidos.Size = new Size(845, 284);
            dgv_itens_fornecidos.TabIndex = 1;
            dgv_itens_fornecidos.CellMouseDoubleClick += dgv_itens_fornecidos_CellMouseDoubleClick;
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            category.HeaderText = "Categoria";
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 85;
            // 
            // id_item
            // 
            id_item.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id_item.HeaderText = "Cód. Item";
            id_item.Name = "id_item";
            id_item.ReadOnly = true;
            id_item.Width = 79;
            // 
            // cod_barras
            // 
            cod_barras.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod_barras.HeaderText = "Cód.Barras";
            cod_barras.Name = "cod_barras";
            cod_barras.ReadOnly = true;
            cod_barras.Width = 91;
            // 
            // name_item
            // 
            name_item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name_item.HeaderText = "Nome item";
            name_item.Name = "name_item";
            name_item.ReadOnly = true;
            // 
            // unity
            // 
            unity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            unity.HeaderText = "Unidade";
            unity.Name = "unity";
            unity.ReadOnly = true;
            unity.Width = 78;
            // 
            // custo
            // 
            custo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            custo.HeaderText = "Preço custo";
            custo.Name = "custo";
            custo.ReadOnly = true;
            custo.Width = 89;
            // 
            // preco
            // 
            preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco.HeaderText = "Preço venda";
            preco.Name = "preco";
            preco.ReadOnly = true;
            preco.Width = 93;
            // 
            // lucro
            // 
            lucro.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lucro.HeaderText = "Lucro";
            lucro.Name = "lucro";
            lucro.ReadOnly = true;
            lucro.Width = 63;
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
            bt_add.Location = new Point(799, 25);
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
            ClientSize = new Size(921, 452);
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
        public Label txt_fornecedor_name;
        private Button bt_add;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn id_item;
        private DataGridViewTextBoxColumn cod_barras;
        private DataGridViewTextBoxColumn name_item;
        private DataGridViewTextBoxColumn unity;
        private DataGridViewTextBoxColumn custo;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn lucro;
    }
}