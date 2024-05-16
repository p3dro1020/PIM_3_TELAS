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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
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
            panel1.Controls.Add(bt_add);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 523);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 75);
            panel1.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Sienna;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Production.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Production.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_Production.Columns.AddRange(new DataGridViewColumn[] { cod, name, amount, date_p, date_c, status, Edit, Delete });
            dgv_Production.Dock = DockStyle.Fill;
            dgv_Production.EnableHeadersVisualStyles = false;
            dgv_Production.Location = new Point(0, 0);
            dgv_Production.Name = "dgv_Production";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Production.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Production.Size = new Size(903, 523);
            dgv_Production.TabIndex = 1;
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
            Load += FrmProduction_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Production).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_Production;
        private Button bt_add;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date_p;
        private DataGridViewTextBoxColumn date_c;
        private DataGridViewTextBoxColumn status;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}