namespace TelaPIM
{
    partial class FrmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            label5 = new Label();
            txt_num_venda = new TextBox();
            label6 = new Label();
            txt_data = new TextBox();
            txt_operador = new TextBox();
            label7 = new Label();
            txt_cod_operador = new TextBox();
            label8 = new Label();
            txt_qtd_produto = new TextBox();
            label9 = new Label();
            txt_produto = new TextBox();
            label10 = new Label();
            txt_cod_barras = new TextBox();
            label12 = new Label();
            txt_valor_un = new TextBox();
            label11 = new Label();
            txt_valor_tot = new TextBox();
            label13 = new Label();
            dgv_sales = new DataGridView();
            contador = new DataGridViewTextBoxColumn();
            cod = new DataGridViewTextBoxColumn();
            unity = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            preco_total = new DataGridViewTextBoxColumn();
            bt_search = new Button();
            btnAdd = new Button();
            txtTotal = new TextBox();
            label2 = new Label();
            txtItem = new TextBox();
            label3 = new Label();
            bt_confirm = new Button();
            txt_unidade = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_sales).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 19);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Nº Venda:";
            // 
            // txt_num_venda
            // 
            txt_num_venda.BackColor = Color.White;
            txt_num_venda.Enabled = false;
            txt_num_venda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_num_venda.Location = new Point(97, 15);
            txt_num_venda.Name = "txt_num_venda";
            txt_num_venda.ReadOnly = true;
            txt_num_venda.Size = new Size(72, 23);
            txt_num_venda.TabIndex = 4;
            txt_num_venda.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 19);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Data:";
            // 
            // txt_data
            // 
            txt_data.BackColor = Color.White;
            txt_data.Enabled = false;
            txt_data.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_data.Location = new Point(237, 15);
            txt_data.Name = "txt_data";
            txt_data.ReadOnly = true;
            txt_data.Size = new Size(90, 23);
            txt_data.TabIndex = 6;
            txt_data.TabStop = false;
            // 
            // txt_operador
            // 
            txt_operador.BackColor = Color.White;
            txt_operador.Enabled = false;
            txt_operador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_operador.Location = new Point(422, 15);
            txt_operador.Name = "txt_operador";
            txt_operador.ReadOnly = true;
            txt_operador.Size = new Size(230, 23);
            txt_operador.TabIndex = 8;
            txt_operador.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 19);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 7;
            label7.Text = "Operador:";
            // 
            // txt_cod_operador
            // 
            txt_cod_operador.BackColor = Color.White;
            txt_cod_operador.Enabled = false;
            txt_cod_operador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cod_operador.Location = new Point(776, 15);
            txt_cod_operador.Name = "txt_cod_operador";
            txt_cod_operador.ReadOnly = true;
            txt_cod_operador.Size = new Size(90, 23);
            txt_cod_operador.TabIndex = 10;
            txt_cod_operador.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(682, 19);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 9;
            label8.Text = "Cód. Operador:";
            // 
            // txt_qtd_produto
            // 
            txt_qtd_produto.BackColor = Color.White;
            txt_qtd_produto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_qtd_produto.Location = new Point(197, 128);
            txt_qtd_produto.Name = "txt_qtd_produto";
            txt_qtd_produto.Size = new Size(90, 23);
            txt_qtd_produto.TabIndex = 2;
            txt_qtd_produto.TextChanged += txt_qtd_produto_TextChanged;
            txt_qtd_produto.KeyPress += txt_qtd_produto_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(197, 110);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 17;
            label9.Text = "Quantidade:";
            // 
            // txt_produto
            // 
            txt_produto.BackColor = Color.White;
            txt_produto.Enabled = false;
            txt_produto.Location = new Point(293, 128);
            txt_produto.Name = "txt_produto";
            txt_produto.Size = new Size(159, 23);
            txt_produto.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(293, 110);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 15;
            label10.Text = "Produto:";
            // 
            // txt_cod_barras
            // 
            txt_cod_barras.BackColor = Color.White;
            txt_cod_barras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cod_barras.Location = new Point(37, 128);
            txt_cod_barras.Name = "txt_cod_barras";
            txt_cod_barras.Size = new Size(111, 23);
            txt_cod_barras.TabIndex = 1;
            txt_cod_barras.KeyUp += txt_cod_barras_KeyUp;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 110);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 11;
            label12.Text = "Cód. Barras:";
            // 
            // txt_valor_un
            // 
            txt_valor_un.BackColor = Color.White;
            txt_valor_un.Enabled = false;
            txt_valor_un.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_valor_un.Location = new Point(543, 128);
            txt_valor_un.Name = "txt_valor_un";
            txt_valor_un.Size = new Size(80, 23);
            txt_valor_un.TabIndex = 20;
            txt_valor_un.TextChanged += txt_valor_un_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(543, 110);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 19;
            label11.Text = "Preço:";
            // 
            // txt_valor_tot
            // 
            txt_valor_tot.BackColor = Color.White;
            txt_valor_tot.Enabled = false;
            txt_valor_tot.Location = new Point(629, 128);
            txt_valor_tot.Name = "txt_valor_tot";
            txt_valor_tot.Size = new Size(74, 23);
            txt_valor_tot.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(629, 110);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 21;
            label13.Text = "Valor total:";
            // 
            // dgv_sales
            // 
            dgv_sales.AllowUserToAddRows = false;
            dgv_sales.BackgroundColor = Color.White;
            dgv_sales.BorderStyle = BorderStyle.None;
            dgv_sales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sales.Columns.AddRange(new DataGridViewColumn[] { contador, cod, unity, name, valor, qtd, preco_total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_sales.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_sales.EnableHeadersVisualStyles = false;
            dgv_sales.Location = new Point(37, 171);
            dgv_sales.Name = "dgv_sales";
            dgv_sales.ReadOnly = true;
            dgv_sales.RowHeadersVisible = false;
            dgv_sales.Size = new Size(830, 326);
            dgv_sales.TabIndex = 24;
            dgv_sales.CellDoubleClick += dgv_sales_CellDoubleClick;
            // 
            // contador
            // 
            contador.HeaderText = "Qtd. Itens";
            contador.Name = "contador";
            contador.ReadOnly = true;
            contador.Width = 75;
            // 
            // cod
            // 
            cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod.HeaderText = "Cód. Produto";
            cod.Name = "cod";
            cod.ReadOnly = true;
            cod.Width = 103;
            // 
            // unity
            // 
            unity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            unity.HeaderText = "Unidade";
            unity.Name = "unity";
            unity.ReadOnly = true;
            unity.Width = 77;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nome";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // valor
            // 
            valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valor.HeaderText = "Valor R$";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 71;
            // 
            // qtd
            // 
            qtd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd.HeaderText = "Quantidade";
            qtd.Name = "qtd";
            qtd.ReadOnly = true;
            qtd.Width = 95;
            // 
            // preco_total
            // 
            preco_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco_total.HeaderText = "Total R$";
            preco_total.Name = "preco_total";
            preco_total.ReadOnly = true;
            preco_total.Width = 70;
            // 
            // bt_search
            // 
            bt_search.Anchor = AnchorStyles.None;
            bt_search.BackColor = SystemColors.Control;
            bt_search.Cursor = Cursors.Hand;
            bt_search.FlatStyle = FlatStyle.Flat;
            bt_search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_search.ForeColor = SystemColors.ControlText;
            bt_search.Location = new Point(154, 128);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(27, 23);
            bt_search.TabIndex = 25;
            bt_search.Text = "...";
            bt_search.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(717, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 26);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.LimeGreen;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(36, 548);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(111, 22);
            txtTotal.TabIndex = 29;
            txtTotal.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 530);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 28;
            label2.Text = "Valor total:";
            // 
            // txtItem
            // 
            txtItem.BackColor = Color.White;
            txtItem.BorderStyle = BorderStyle.None;
            txtItem.Enabled = false;
            txtItem.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItem.ForeColor = Color.Black;
            txtItem.Location = new Point(172, 548);
            txtItem.Name = "txtItem";
            txtItem.ReadOnly = true;
            txtItem.Size = new Size(37, 22);
            txtItem.TabIndex = 31;
            txtItem.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 530);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 30;
            label3.Text = "Total itens:";
            // 
            // bt_confirm
            // 
            bt_confirm.Anchor = AnchorStyles.None;
            bt_confirm.BackColor = Color.Transparent;
            bt_confirm.Cursor = Cursors.Hand;
            bt_confirm.FlatStyle = FlatStyle.Flat;
            bt_confirm.ForeColor = Color.White;
            bt_confirm.Image = (Image)resources.GetObject("bt_confirm.Image");
            bt_confirm.Location = new Point(832, 544);
            bt_confirm.Name = "bt_confirm";
            bt_confirm.Size = new Size(34, 31);
            bt_confirm.TabIndex = 6;
            bt_confirm.UseVisualStyleBackColor = false;
            bt_confirm.Click += bt_confirm_Click;
            // 
            // txt_unidade
            // 
            txt_unidade.BackColor = Color.White;
            txt_unidade.Enabled = false;
            txt_unidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_unidade.Location = new Point(466, 129);
            txt_unidade.Name = "txt_unidade";
            txt_unidade.Size = new Size(64, 23);
            txt_unidade.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 110);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 32;
            label1.Text = "Unidade:";
            // 
            // FrmSales
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(903, 598);
            Controls.Add(txt_unidade);
            Controls.Add(label1);
            Controls.Add(bt_confirm);
            Controls.Add(txtItem);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(bt_search);
            Controls.Add(dgv_sales);
            Controls.Add(txt_valor_tot);
            Controls.Add(label13);
            Controls.Add(txt_valor_un);
            Controls.Add(label11);
            Controls.Add(txt_qtd_produto);
            Controls.Add(label9);
            Controls.Add(txt_produto);
            Controls.Add(label10);
            Controls.Add(txt_cod_barras);
            Controls.Add(label12);
            Controls.Add(txt_cod_operador);
            Controls.Add(label8);
            Controls.Add(txt_operador);
            Controls.Add(label7);
            Controls.Add(txt_data);
            Controls.Add(label6);
            Controls.Add(txt_num_venda);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSales";
            Text = "FrmSales";
            Load += FrmSales_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txt_num_venda;
        private Label label6;
        private TextBox txt_data;
        private TextBox txt_operador;
        private Label label7;
        private TextBox txt_cod_operador;
        private Label label8;
        private TextBox txt_qtd_produto;
        private Label label9;
        private TextBox txt_produto;
        private Label label10;
        private TextBox txt_cod_barras;
        private Label label12;
        private TextBox txt_valor_un;
        private Label label11;
        private TextBox txt_valor_tot;
        private Label label13;
        private Button bt_search;
        private Button btnAdd;
        private TextBox txtTotal;
        private Label label2;
        private Label label3;
        private Button bt_confirm;
        private TextBox txt_unidade;
        private Label label1;
        private DataGridViewTextBoxColumn contador;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn unity;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn preco_total;
        public TextBox txtItem;
        public DataGridView dgv_sales;
    }
}