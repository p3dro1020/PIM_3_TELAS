namespace TelaPIM
{
    partial class FrmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppliers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            bt_listAll = new Button();
            bt_search = new Button();
            txt_search = new TextBox();
            label1 = new Label();
            bt_addSuppliers = new Button();
            dgv_suppliers = new DataGridView();
            cod = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dt_cadastro = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            cellphone = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(bt_listAll);
            panel1.Controls.Add(bt_search);
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bt_addSuppliers);
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
            bt_listAll.Location = new Point(3, 26);
            bt_listAll.Name = "bt_listAll";
            bt_listAll.Size = new Size(37, 31);
            bt_listAll.TabIndex = 9;
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
            bt_search.Location = new Point(598, 26);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(37, 31);
            bt_search.TabIndex = 8;
            bt_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(385, 28);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(207, 23);
            txt_search.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 31);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar";
            // 
            // bt_addSuppliers
            // 
            bt_addSuppliers.Anchor = AnchorStyles.None;
            bt_addSuppliers.BackColor = Color.Sienna;
            bt_addSuppliers.Cursor = Cursors.Hand;
            bt_addSuppliers.FlatStyle = FlatStyle.Flat;
            bt_addSuppliers.ForeColor = Color.Sienna;
            bt_addSuppliers.Image = (Image)resources.GetObject("bt_addSuppliers.Image");
            bt_addSuppliers.Location = new Point(857, 20);
            bt_addSuppliers.Name = "bt_addSuppliers";
            bt_addSuppliers.Size = new Size(34, 31);
            bt_addSuppliers.TabIndex = 2;
            bt_addSuppliers.UseVisualStyleBackColor = true;
            bt_addSuppliers.Click += bt_addSuppliers_Click;
            // 
            // dgv_suppliers
            // 
            dgv_suppliers.AllowUserToAddRows = false;
            dgv_suppliers.BackgroundColor = Color.White;
            dgv_suppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Sienna;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_suppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_suppliers.Columns.AddRange(new DataGridViewColumn[] { cod, cnpj, name, email, dt_cadastro, info, cellphone });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_suppliers.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_suppliers.Dock = DockStyle.Fill;
            dgv_suppliers.EnableHeadersVisualStyles = false;
            dgv_suppliers.Location = new Point(0, 0);
            dgv_suppliers.MultiSelect = false;
            dgv_suppliers.Name = "dgv_suppliers";
            dgv_suppliers.ReadOnly = true;
            dgv_suppliers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_suppliers.RowHeadersVisible = false;
            dgv_suppliers.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_suppliers.Size = new Size(903, 523);
            dgv_suppliers.TabIndex = 1;
            dgv_suppliers.CellContentClick += dgv_suppliers_CellContentClick;
            dgv_suppliers.CellMouseDoubleClick += dgv_suppliers_CellMouseDoubleClick;
            // 
            // cod
            // 
            cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod.HeaderText = "Cód.";
            cod.Name = "cod";
            cod.ReadOnly = true;
            cod.Width = 55;
            // 
            // cnpj
            // 
            cnpj.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            cnpj.Width = 58;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nome fantasia";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 60;
            // 
            // dt_cadastro
            // 
            dt_cadastro.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dt_cadastro.HeaderText = "Data cadastro";
            dt_cadastro.Name = "dt_cadastro";
            dt_cadastro.ReadOnly = true;
            dt_cadastro.Width = 107;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            info.HeaderText = "";
            info.Image = (Image)resources.GetObject("info.Image");
            info.Name = "info";
            info.ReadOnly = true;
            info.Width = 5;
            // 
            // cellphone
            // 
            cellphone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cellphone.HeaderText = "";
            cellphone.Image = (Image)resources.GetObject("cellphone.Image");
            cellphone.Name = "cellphone";
            cellphone.ReadOnly = true;
            cellphone.Width = 5;
            // 
            // FrmSuppliers
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(903, 598);
            Controls.Add(dgv_suppliers);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSuppliers";
            Text = "FrmSuppliers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_suppliers;
        private Button bt_addSuppliers;
        private Button bt_listAll;
        private Button bt_search;
        private TextBox txt_search;
        private Label label1;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn cnpj;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dt_cadastro;
        private DataGridViewImageColumn info;
        private DataGridViewImageColumn cellphone;
    }
}