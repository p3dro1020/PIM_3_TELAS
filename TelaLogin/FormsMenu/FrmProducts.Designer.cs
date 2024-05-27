namespace TelaPIM
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            bt_listAll = new Button();
            bt_search = new Button();
            txt_search = new TextBox();
            label1 = new Label();
            bt_add = new Button();
            dgv_products = new DataGridView();
            cod = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            preco_unico = new DataGridViewTextBoxColumn();
            preco_total = new DataGridViewTextBoxColumn();
            fornecedor = new DataGridViewTextBoxColumn();
            dt_vencimento = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
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
            // 
            // bt_search
            // 
            bt_search.Anchor = AnchorStyles.None;
            bt_search.BackColor = Color.Sienna;
            bt_search.Cursor = Cursors.Hand;
            bt_search.FlatStyle = FlatStyle.Flat;
            bt_search.ForeColor = Color.Sienna;
            bt_search.Image = (Image)resources.GetObject("bt_search.Image");
            bt_search.Location = new Point(529, 22);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(37, 31);
            bt_search.TabIndex = 9;
            bt_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(386, 24);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(137, 23);
            txt_search.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 27);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
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
            // 
            // dgv_products
            // 
            dgv_products.AllowUserToAddRows = false;
            dgv_products.BackgroundColor = Color.White;
            dgv_products.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Sienna;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_products.Columns.AddRange(new DataGridViewColumn[] { cod, name, qtd, preco_unico, preco_total, fornecedor, dt_vencimento, edit, delete });
            dgv_products.Dock = DockStyle.Fill;
            dgv_products.EnableHeadersVisualStyles = false;
            dgv_products.Location = new Point(0, 0);
            dgv_products.Name = "dgv_products";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_products.Size = new Size(903, 523);
            dgv_products.TabIndex = 1;
            // 
            // cod
            // 
            cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod.HeaderText = "Cód.";
            cod.Name = "cod";
            cod.Width = 55;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name.HeaderText = "Nome";
            name.Name = "name";
            name.Width = 65;
            // 
            // qtd
            // 
            qtd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd.HeaderText = "Quantidade em estoque";
            qtd.Name = "qtd";
            qtd.Width = 164;
            // 
            // preco_unico
            // 
            preco_unico.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco_unico.HeaderText = "Preço único";
            preco_unico.Name = "preco_unico";
            preco_unico.Width = 96;
            // 
            // preco_total
            // 
            preco_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco_total.HeaderText = "Preço estoque total";
            preco_total.Name = "preco_total";
            preco_total.Width = 140;
            // 
            // fornecedor
            // 
            fornecedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fornecedor.HeaderText = "Fornecedor";
            fornecedor.Name = "fornecedor";
            // 
            // dt_vencimento
            // 
            dt_vencimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dt_vencimento.HeaderText = "Data vencimento";
            dt_vencimento.Name = "dt_vencimento";
            dt_vencimento.Width = 127;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit.HeaderText = "";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.Name = "edit";
            edit.Width = 5;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            delete.HeaderText = "";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.Name = "delete";
            delete.Width = 5;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(903, 598);
            Controls.Add(dgv_products);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            Text = "FrmProducts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_products;
        private Button bt_listAll;
        private Button bt_search;
        private TextBox txt_search;
        private Label label1;
        private Button bt_add;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn preco_unico;
        private DataGridViewTextBoxColumn preco_total;
        private DataGridViewTextBoxColumn fornecedor;
        private DataGridViewTextBoxColumn dt_vencimento;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
    }
}