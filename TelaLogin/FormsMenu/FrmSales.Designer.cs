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
            panel1 = new Panel();
            bt_confirm = new Button();
            txt_total_itens = new Label();
            label4 = new Label();
            txt_valor_total = new Label();
            label1 = new Label();
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
            bt_add = new Button();
            dgv_sales = new DataGridView();
            contador = new DataGridViewTextBoxColumn();
            cod = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            unity = new DataGridViewTextBoxColumn();
            preco_total = new DataGridViewTextBoxColumn();
            bt_search = new Button();
            bt_excluir = new Button();
            bt_edit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sales).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(bt_excluir);
            panel1.Controls.Add(bt_confirm);
            panel1.Controls.Add(txt_total_itens);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_valor_total);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 523);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 75);
            panel1.TabIndex = 2;
            // 
            // bt_confirm
            // 
            bt_confirm.Anchor = AnchorStyles.None;
            bt_confirm.BackColor = Color.Sienna;
            bt_confirm.Cursor = Cursors.Hand;
            bt_confirm.FlatStyle = FlatStyle.Flat;
            bt_confirm.ForeColor = Color.Sienna;
            bt_confirm.Image = (Image)resources.GetObject("bt_confirm.Image");
            bt_confirm.Location = new Point(857, 21);
            bt_confirm.Name = "bt_confirm";
            bt_confirm.Size = new Size(34, 31);
            bt_confirm.TabIndex = 24;
            bt_confirm.UseVisualStyleBackColor = false;
            // 
            // txt_total_itens
            // 
            txt_total_itens.AutoSize = true;
            txt_total_itens.Location = new Point(571, 37);
            txt_total_itens.Name = "txt_total_itens";
            txt_total_itens.Size = new Size(14, 15);
            txt_total_itens.TabIndex = 3;
            txt_total_itens.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 16);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 2;
            label4.Text = "TOTAL ITENS";
            // 
            // txt_valor_total
            // 
            txt_valor_total.AutoSize = true;
            txt_valor_total.Location = new Point(271, 37);
            txt_valor_total.Name = "txt_valor_total";
            txt_valor_total.Size = new Size(49, 15);
            txt_valor_total.TabIndex = 1;
            txt_valor_total.Text = "R$ 0,00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 16);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "VALOR TOTAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 15);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Nº Venda:";
            // 
            // txt_num_venda
            // 
            txt_num_venda.Enabled = false;
            txt_num_venda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_num_venda.Location = new Point(83, 12);
            txt_num_venda.Name = "txt_num_venda";
            txt_num_venda.Size = new Size(72, 23);
            txt_num_venda.TabIndex = 4;
            txt_num_venda.Text = "135";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 15);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Data:";
            // 
            // txt_data
            // 
            txt_data.Enabled = false;
            txt_data.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_data.Location = new Point(220, 12);
            txt_data.Name = "txt_data";
            txt_data.Size = new Size(90, 23);
            txt_data.TabIndex = 6;
            txt_data.Text = "26/05/2024";
            // 
            // txt_operador
            // 
            txt_operador.Enabled = false;
            txt_operador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_operador.Location = new Point(417, 12);
            txt_operador.Name = "txt_operador";
            txt_operador.Size = new Size(230, 23);
            txt_operador.TabIndex = 8;
            txt_operador.Text = "Pedro Teste";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 15);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 7;
            label7.Text = "Operador:";
            // 
            // txt_cod_operador
            // 
            txt_cod_operador.Enabled = false;
            txt_cod_operador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cod_operador.Location = new Point(758, 12);
            txt_cod_operador.Name = "txt_cod_operador";
            txt_cod_operador.Size = new Size(90, 23);
            txt_cod_operador.TabIndex = 10;
            txt_cod_operador.Text = "001";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(664, 15);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 9;
            label8.Text = "Cód. Operador:";
            // 
            // txt_qtd_produto
            // 
            txt_qtd_produto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_qtd_produto.Location = new Point(448, 128);
            txt_qtd_produto.Name = "txt_qtd_produto";
            txt_qtd_produto.Size = new Size(90, 23);
            txt_qtd_produto.TabIndex = 18;
            txt_qtd_produto.Text = "3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(448, 110);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 17;
            label9.Text = "Quantidade:";
            // 
            // txt_produto
            // 
            txt_produto.Enabled = false;
            txt_produto.Location = new Point(171, 128);
            txt_produto.Name = "txt_produto";
            txt_produto.Size = new Size(230, 23);
            txt_produto.TabIndex = 16;
            txt_produto.Text = "Alface";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(171, 110);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 15;
            label10.Text = "Produto:";
            // 
            // txt_cod_barras
            // 
            txt_cod_barras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cod_barras.Location = new Point(18, 128);
            txt_cod_barras.Name = "txt_cod_barras";
            txt_cod_barras.Size = new Size(111, 23);
            txt_cod_barras.TabIndex = 12;
            txt_cod_barras.Text = "001";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 110);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 11;
            label12.Text = "Cód. Barras:";
            // 
            // txt_valor_un
            // 
            txt_valor_un.Enabled = false;
            txt_valor_un.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_valor_un.Location = new Point(553, 128);
            txt_valor_un.Name = "txt_valor_un";
            txt_valor_un.Size = new Size(90, 23);
            txt_valor_un.TabIndex = 20;
            txt_valor_un.Text = "R$ 5,00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(553, 110);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 19;
            label11.Text = "Unidade:";
            // 
            // txt_valor_tot
            // 
            txt_valor_tot.Enabled = false;
            txt_valor_tot.Location = new Point(662, 128);
            txt_valor_tot.Name = "txt_valor_tot";
            txt_valor_tot.Size = new Size(90, 23);
            txt_valor_tot.TabIndex = 22;
            txt_valor_tot.Text = "R$ 15,00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(662, 110);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 21;
            label13.Text = "Valor total:";
            // 
            // bt_add
            // 
            bt_add.Anchor = AnchorStyles.None;
            bt_add.BackColor = Color.White;
            bt_add.Cursor = Cursors.Hand;
            bt_add.FlatStyle = FlatStyle.Flat;
            bt_add.ForeColor = Color.White;
            bt_add.Image = (Image)resources.GetObject("bt_add.Image");
            bt_add.Location = new Point(758, 123);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(34, 31);
            bt_add.TabIndex = 23;
            bt_add.UseVisualStyleBackColor = false;
            // 
            // dgv_sales
            // 
            dgv_sales.BackgroundColor = Color.White;
            dgv_sales.BorderStyle = BorderStyle.None;
            dgv_sales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Sienna;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sales.Columns.AddRange(new DataGridViewColumn[] { contador, cod, name, qtd, unity, preco_total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_sales.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_sales.EnableHeadersVisualStyles = false;
            dgv_sales.Location = new Point(18, 175);
            dgv_sales.Name = "dgv_sales";
            dgv_sales.RowHeadersVisible = false;
            dgv_sales.Size = new Size(830, 314);
            dgv_sales.TabIndex = 24;
            // 
            // contador
            // 
            contador.HeaderText = "Qtd. Itens";
            contador.Name = "contador";
            contador.Width = 75;
            // 
            // cod
            // 
            cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cod.HeaderText = "Cód. Produto";
            cod.Name = "cod";
            cod.Width = 103;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nome";
            name.Name = "name";
            // 
            // qtd
            // 
            qtd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtd.HeaderText = "Quantidade";
            qtd.Name = "qtd";
            qtd.Width = 95;
            // 
            // unity
            // 
            unity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            unity.HeaderText = "Unidade";
            unity.Name = "unity";
            unity.Width = 77;
            // 
            // preco_total
            // 
            preco_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preco_total.HeaderText = "Total";
            preco_total.Name = "preco_total";
            preco_total.Width = 58;
            // 
            // bt_search
            // 
            bt_search.Anchor = AnchorStyles.None;
            bt_search.BackColor = Color.White;
            bt_search.Cursor = Cursors.Hand;
            bt_search.FlatStyle = FlatStyle.Flat;
            bt_search.ForeColor = Color.White;
            bt_search.Image = (Image)resources.GetObject("bt_search.Image");
            bt_search.Location = new Point(135, 125);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(20, 26);
            bt_search.TabIndex = 25;
            bt_search.UseVisualStyleBackColor = false;
            // 
            // bt_excluir
            // 
            bt_excluir.Anchor = AnchorStyles.None;
            bt_excluir.BackColor = Color.Sienna;
            bt_excluir.Cursor = Cursors.Hand;
            bt_excluir.FlatStyle = FlatStyle.Flat;
            bt_excluir.ForeColor = Color.Sienna;
            bt_excluir.Image = (Image)resources.GetObject("bt_excluir.Image");
            bt_excluir.Location = new Point(817, 21);
            bt_excluir.Name = "bt_excluir";
            bt_excluir.Size = new Size(34, 31);
            bt_excluir.TabIndex = 25;
            bt_excluir.UseVisualStyleBackColor = false;
            // 
            // bt_edit
            // 
            bt_edit.Anchor = AnchorStyles.None;
            bt_edit.BackColor = Color.White;
            bt_edit.Cursor = Cursors.Hand;
            bt_edit.FlatStyle = FlatStyle.Flat;
            bt_edit.ForeColor = Color.White;
            bt_edit.Image = (Image)resources.GetObject("bt_edit.Image");
            bt_edit.Location = new Point(798, 123);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(34, 31);
            bt_edit.TabIndex = 26;
            bt_edit.UseVisualStyleBackColor = false;
            // 
            // FrmSales
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(903, 598);
            Controls.Add(bt_edit);
            Controls.Add(bt_search);
            Controls.Add(dgv_sales);
            Controls.Add(bt_add);
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
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSales";
            Text = "FrmSales";
            Load += FrmSales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label txt_valor_total;
        private Label label1;
        private Label txt_total_itens;
        private Label label4;
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
        private Button bt_add;
        private DataGridView dgv_sales;
        private DataGridViewTextBoxColumn contador;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn unity;
        private DataGridViewTextBoxColumn preco_total;
        private Button bt_confirm;
        private Button bt_search;
        private Button bt_excluir;
        private Button bt_edit;
    }
}