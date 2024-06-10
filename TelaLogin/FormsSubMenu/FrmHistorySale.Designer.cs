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
            pagamento = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            data_inicio = new DateTimePicker();
            data_fim = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_faturamento = new TextBox();
            bt_listAll = new Button();
            bt_relatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_history_sale).BeginInit();
            SuspendLayout();
            // 
            // dgv_history_sale
            // 
            dgv_history_sale.AllowUserToAddRows = false;
            dgv_history_sale.BackgroundColor = Color.White;
            dgv_history_sale.BorderStyle = BorderStyle.None;
            dgv_history_sale.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_history_sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_history_sale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history_sale.Columns.AddRange(new DataGridViewColumn[] { id_pedido, date, pagamento, qtd, total, info });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_history_sale.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_history_sale.EnableHeadersVisualStyles = false;
            dgv_history_sale.GridColor = Color.Black;
            dgv_history_sale.Location = new Point(12, 12);
            dgv_history_sale.Name = "dgv_history_sale";
            dgv_history_sale.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
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
            id_pedido.Width = 96;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "Data da venda";
            date.Name = "date";
            // 
            // pagamento
            // 
            pagamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pagamento.HeaderText = "Pagamento";
            pagamento.Name = "pagamento";
            pagamento.Width = 94;
            // 
            // qtd
            // 
            qtd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd.HeaderText = "Qtd. Itens";
            qtd.Name = "qtd";
            qtd.Width = 86;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            total.HeaderText = "Valor total";
            total.Name = "total";
            total.Width = 88;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            info.HeaderText = "";
            info.Image = (Image)resources.GetObject("info.Image");
            info.Name = "info";
            info.Width = 5;
            // 
            // data_inicio
            // 
            data_inicio.Format = DateTimePickerFormat.Short;
            data_inicio.Location = new Point(49, 415);
            data_inicio.Name = "data_inicio";
            data_inicio.Size = new Size(103, 23);
            data_inicio.TabIndex = 1;
            data_inicio.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            data_inicio.ValueChanged += data_inicio_ValueChanged;
            // 
            // data_fim
            // 
            data_fim.Format = DateTimePickerFormat.Short;
            data_fim.Location = new Point(49, 455);
            data_fim.Name = "data_fim";
            data_fim.Size = new Size(103, 23);
            data_fim.TabIndex = 2;
            data_fim.ValueChanged += data_fim_ValueChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 419);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Faturamento total";
            // 
            // txt_faturamento
            // 
            txt_faturamento.Enabled = false;
            txt_faturamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_faturamento.Location = new Point(286, 415);
            txt_faturamento.Name = "txt_faturamento";
            txt_faturamento.Size = new Size(100, 23);
            txt_faturamento.TabIndex = 6;
            // 
            // bt_listAll
            // 
            bt_listAll.Location = new Point(49, 492);
            bt_listAll.Name = "bt_listAll";
            bt_listAll.Size = new Size(75, 23);
            bt_listAll.TabIndex = 8;
            bt_listAll.Text = "Listar tudo";
            bt_listAll.UseVisualStyleBackColor = true;
            bt_listAll.Click += bt_listAll_Click;
            // 
            // bt_relatorio
            // 
            bt_relatorio.Location = new Point(651, 455);
            bt_relatorio.Name = "bt_relatorio";
            bt_relatorio.Size = new Size(107, 23);
            bt_relatorio.TabIndex = 9;
            bt_relatorio.Text = "Gerar relatório";
            bt_relatorio.UseVisualStyleBackColor = true;
            bt_relatorio.Click += bt_relatorio_Click;
            // 
            // FrmHistorySale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(863, 527);
            Controls.Add(bt_relatorio);
            Controls.Add(bt_listAll);
            Controls.Add(txt_faturamento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(data_fim);
            Controls.Add(data_inicio);
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
        private DateTimePicker data_inicio;
        private DateTimePicker data_fim;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn id_pedido;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn pagamento;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn total;
        private DataGridViewImageColumn info;
        private Label label3;
        private TextBox txt_faturamento;
        private Button bt_listAll;
        private Button bt_relatorio;
    }
}