namespace TelaPIM
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            rb_categoria = new RadioButton();
            rb_nome = new RadioButton();
            bt_listAll = new Button();
            bt_search = new Button();
            txt_search = new TextBox();
            label1 = new Label();
            bt_add = new Button();
            dgv_stock = new DataGridView();
            cod = new DataGridViewTextBoxColumn();
            cod_barras = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            un = new DataGridViewTextBoxColumn();
            preco_unico = new DataGridViewTextBoxColumn();
            preco_total = new DataGridViewTextBoxColumn();
            fornecedor = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_stock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(rb_categoria);
            panel1.Controls.Add(rb_nome);
            panel1.Controls.Add(bt_listAll);
            panel1.Controls.Add(bt_search);
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bt_add);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 523);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 75);
            panel1.TabIndex = 0;
            // 
            // rb_categoria
            // 
            rb_categoria.AutoSize = true;
            rb_categoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rb_categoria.Location = new Point(231, 44);
            rb_categoria.Name = "rb_categoria";
            rb_categoria.Size = new Size(78, 19);
            rb_categoria.TabIndex = 12;
            rb_categoria.TabStop = true;
            rb_categoria.Text = "Categoria";
            rb_categoria.UseVisualStyleBackColor = true;
            // 
            // rb_nome
            // 
            rb_nome.AutoSize = true;
            rb_nome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rb_nome.Location = new Point(231, 16);
            rb_nome.Name = "rb_nome";
            rb_nome.Size = new Size(59, 19);
            rb_nome.TabIndex = 11;
            rb_nome.TabStop = true;
            rb_nome.Text = "Nome";
            rb_nome.UseVisualStyleBackColor = true;
            // 
            // bt_listAll
            // 
            bt_listAll.Anchor = AnchorStyles.None;
            bt_listAll.BackColor = Color.Sienna;
            bt_listAll.Cursor = Cursors.Hand;
            bt_listAll.FlatStyle = FlatStyle.Flat;
            bt_listAll.ForeColor = Color.Sienna;
            bt_listAll.Image = (Image)resources.GetObject("bt_listAll.Image");
            bt_listAll.Location = new Point(12, 22);
            bt_listAll.Name = "bt_listAll";
            bt_listAll.Size = new Size(37, 31);
            bt_listAll.TabIndex = 10;
            bt_listAll.UseVisualStyleBackColor = true;
            bt_listAll.Click += bt_listAll_Click;
            // 
            // bt_search
            // 
            bt_search.Anchor = AnchorStyles.None;
            bt_search.BackColor = Color.Sienna;
            bt_search.Cursor = Cursors.Hand;
            bt_search.FlatStyle = FlatStyle.Flat;
            bt_search.ForeColor = Color.Sienna;
            bt_search.Image = (Image)resources.GetObject("bt_search.Image");
            bt_search.Location = new Point(529, 25);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(37, 31);
            bt_search.TabIndex = 9;
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(386, 27);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(137, 23);
            txt_search.TabIndex = 8;
            txt_search.KeyPress += txt_search_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(323, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Pesquisar";
            // 
            // bt_add
            // 
            bt_add.Anchor = AnchorStyles.None;
            bt_add.BackColor = Color.Sienna;
            bt_add.Cursor = Cursors.Hand;
            bt_add.FlatStyle = FlatStyle.Flat;
            bt_add.ForeColor = Color.Sienna;
            bt_add.Image = (Image)resources.GetObject("bt_add.Image");
            bt_add.Location = new Point(857, 22);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(34, 31);
            bt_add.TabIndex = 6;
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // dgv_stock
            // 
            dgv_stock.AllowUserToAddRows = false;
            dgv_stock.BackgroundColor = Color.White;
            dgv_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Sienna;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_stock.Columns.AddRange(new DataGridViewColumn[] { cod, cod_barras, name, category, qtd, un, preco_unico, preco_total, fornecedor, edit, delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_stock.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_stock.Dock = DockStyle.Fill;
            dgv_stock.EnableHeadersVisualStyles = false;
            dgv_stock.Location = new Point(0, 0);
            dgv_stock.Name = "dgv_stock";
            dgv_stock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_stock.RowHeadersVisible = false;
            dgv_stock.Size = new Size(903, 523);
            dgv_stock.TabIndex = 1;
            dgv_stock.CellContentClick += dgv_stock_CellContentClick;
            // 
            // cod
            // 
            cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod.HeaderText = "Cód. Produto";
            cod.Name = "cod";
            cod.ReadOnly = true;
            cod.Width = 103;
            // 
            // cod_barras
            // 
            cod_barras.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod_barras.HeaderText = "Cód. Barras";
            cod_barras.Name = "cod_barras";
            cod_barras.ReadOnly = true;
            cod_barras.Width = 93;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name.HeaderText = "Nome";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 65;
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            category.HeaderText = "Categoria";
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 84;
            // 
            // qtd
            // 
            qtd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd.HeaderText = "Qtd.";
            qtd.Name = "qtd";
            qtd.ReadOnly = true;
            qtd.Width = 55;
            // 
            // un
            // 
            un.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            un.HeaderText = "UN";
            un.Name = "un";
            un.ReadOnly = true;
            un.Width = 49;
            // 
            // preco_unico
            // 
            preco_unico.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco_unico.HeaderText = "Preço venda";
            preco_unico.Name = "preco_unico";
            preco_unico.ReadOnly = true;
            // 
            // preco_total
            // 
            preco_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco_total.HeaderText = "Preço estoque total";
            preco_total.Name = "preco_total";
            preco_total.ReadOnly = true;
            preco_total.Width = 140;
            // 
            // fornecedor
            // 
            fornecedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fornecedor.HeaderText = "Fornecedor";
            fornecedor.Name = "fornecedor";
            fornecedor.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit.HeaderText = "";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Width = 5;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            delete.HeaderText = "";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Width = 5;
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(903, 598);
            Controls.Add(dgv_stock);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStock";
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_stock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_stock;
        private Button bt_listAll;
        private Button bt_search;
        private TextBox txt_search;
        private Label label1;
        private Button bt_add;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn cod_barras;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn un;
        private DataGridViewTextBoxColumn preco_unico;
        private DataGridViewTextBoxColumn preco_total;
        private DataGridViewTextBoxColumn fornecedor;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private RadioButton rb_categoria;
        private RadioButton rb_nome;
    }
}