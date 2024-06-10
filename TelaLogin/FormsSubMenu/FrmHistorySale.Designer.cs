namespace TelaLogin.FormsSubMenu
{
    partial class FrmHistorySale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorySale));
            dgv_history_sale = new DataGridView();
            id_pedido = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_history_sale).BeginInit();
            SuspendLayout();
            // 
            // dgv_history_sale
            // 
            dgv_history_sale.AllowUserToAddRows = false;
            dgv_history_sale.BackgroundColor = Color.White;
            dgv_history_sale.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_history_sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_history_sale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history_sale.Columns.AddRange(new DataGridViewColumn[] { id_pedido, date, qtd, total, info });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_history_sale.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_history_sale.GridColor = Color.Black;
            dgv_history_sale.Location = new Point(12, 12);
            dgv_history_sale.Name = "dgv_history_sale";
            dgv_history_sale.RowHeadersVisible = false;
            dgv_history_sale.Size = new Size(808, 397);
            dgv_history_sale.TabIndex = 0;
            dgv_history_sale.CellContentClick += dgv_history_sale_CellContentClick;
            // 
            // id_pedido
            // 
            id_pedido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id_pedido.HeaderText = "Cód. Pedido";
            id_pedido.Name = "id_pedido";
            id_pedido.Width = 97;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "Data da venda";
            date.Name = "date";
            // 
            // qtd
            // 
            qtd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd.HeaderText = "Qtd. Itens";
            qtd.Name = "qtd";
            qtd.Width = 87;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            total.HeaderText = "Valor total";
            total.Name = "total";
            total.Width = 89;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            info.HeaderText = "";
            info.Image = (Image)resources.GetObject("info.Image");
            info.Name = "info";
            info.Width = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(49, 415);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(49, 455);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(103, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 419);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 3;
            label1.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 459);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Até:";
            // 
            // FrmHistorySale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(863, 527);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgv_history_sale);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmHistorySale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico vendas";
            Load += FrmHistorySale_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_history_sale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_history_sale;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn id_pedido;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn total;
        private DataGridViewImageColumn info;
    }
}