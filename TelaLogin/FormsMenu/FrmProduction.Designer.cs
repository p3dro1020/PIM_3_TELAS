namespace TelaPIM
{
    partial class FrmProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduction));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            rb_status = new RadioButton();
            rb_nome = new RadioButton();
            bt_listAll = new Button();
            bt_search = new Button();
            txt_search = new TextBox();
            label1 = new Label();
            bt_add = new Button();
            dgv_Production = new DataGridView();
            cod = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            date_p = new DataGridViewTextBoxColumn();
            date_c = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Production).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(rb_status);
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
            // rb_status
            // 
            rb_status.AutoSize = true;
            rb_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rb_status.Location = new Point(202, 42);
            rb_status.Name = "rb_status";
            rb_status.Size = new Size(60, 19);
            rb_status.TabIndex = 7;
            rb_status.TabStop = true;
            rb_status.Text = "Status";
            rb_status.UseVisualStyleBackColor = true;
            // 
            // rb_nome
            // 
            rb_nome.AutoSize = true;
            rb_nome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rb_nome.Location = new Point(202, 17);
            rb_nome.Name = "rb_nome";
            rb_nome.Size = new Size(59, 19);
            rb_nome.TabIndex = 6;
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
            bt_listAll.Location = new Point(12, 23);
            bt_listAll.Name = "bt_listAll";
            bt_listAll.Size = new Size(37, 31);
            bt_listAll.TabIndex = 5;
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
            bt_search.Location = new Point(555, 26);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(37, 31);
            bt_search.TabIndex = 4;
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(412, 28);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(137, 23);
            txt_search.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(349, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
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
            bt_add.Location = new Point(857, 23);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(34, 31);
            bt_add.TabIndex = 1;
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // dgv_Production
            // 
            dgv_Production.AllowUserToAddRows = false;
            dgv_Production.BackgroundColor = Color.White;
            dgv_Production.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Sienna;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Production.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Production.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_Production.Columns.AddRange(new DataGridViewColumn[] { cod, name, amount, date_p, date_c, status, Edit, Delete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Production.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Production.Dock = DockStyle.Fill;
            dgv_Production.EnableHeadersVisualStyles = false;
            dgv_Production.Location = new Point(0, 0);
            dgv_Production.Name = "dgv_Production";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Production.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Production.RowHeadersVisible = false;
            dgv_Production.Size = new Size(903, 523);
            dgv_Production.TabIndex = 1;
            dgv_Production.CellContentClick += dgv_Production_CellContentClick;
            // 
            // cod
            // 
            cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod.HeaderText = "Código";
            cod.Name = "cod";
            cod.Width = 69;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 35F;
            name.HeaderText = "Nome";
            name.Name = "name";
            // 
            // amount
            // 
            amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amount.HeaderText = "Quantidade";
            amount.Name = "amount";
            amount.Width = 95;
            // 
            // date_p
            // 
            date_p.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            date_p.HeaderText = "Data plantio";
            date_p.Name = "date_p";
            date_p.Width = 98;
            // 
            // date_c
            // 
            date_c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            date_c.HeaderText = "Data colheita esperada";
            date_c.Name = "date_c";
            date_c.Width = 157;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            status.HeaderText = "Status";
            status.Name = "status";
            status.Width = 66;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.Name = "Edit";
            Edit.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // FrmProduction
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(903, 598);
            Controls.Add(dgv_Production);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProduction";
            Text = "FrmProduction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Production).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_add;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date_p;
        private DataGridViewTextBoxColumn date_c;
        private DataGridViewTextBoxColumn status;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        public DataGridView dgv_Production;
        private TextBox txt_search;
        private Label label1;
        private Button bt_search;
        private Button bt_listAll;
        private RadioButton rb_status;
        private RadioButton rb_nome;
    }
}