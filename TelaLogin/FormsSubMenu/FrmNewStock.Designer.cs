namespace TelaLogin.FormsSubMenu
{
    partial class FrmNewStock
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
            label1 = new Label();
            txt_produto = new TextBox();
            txt_nome = new TextBox();
            label2 = new Label();
            txt_cdg_barra = new TextBox();
            label3 = new Label();
            txt_categoria = new TextBox();
            label4 = new Label();
            txt_qtd = new TextBox();
            label5 = new Label();
            txt_unidade = new TextBox();
            label6 = new Label();
            txt_preco_venda = new TextBox();
            label7 = new Label();
            txt_fornecedor = new TextBox();
            label8 = new Label();
            bt_add = new Button();
            bt_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(83, 56);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Cód. Produto";
            // 
            // txt_produto
            // 
            txt_produto.Enabled = false;
            txt_produto.ForeColor = Color.Black;
            txt_produto.Location = new Point(83, 74);
            txt_produto.Name = "txt_produto";
            txt_produto.Size = new Size(100, 23);
            txt_produto.TabIndex = 1;
            // 
            // txt_nome
            // 
            txt_nome.Enabled = false;
            txt_nome.ForeColor = Color.Black;
            txt_nome.Location = new Point(201, 126);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(175, 23);
            txt_nome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(201, 108);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome produto";
            // 
            // txt_cdg_barra
            // 
            txt_cdg_barra.BackColor = Color.White;
            txt_cdg_barra.Location = new Point(201, 74);
            txt_cdg_barra.Name = "txt_cdg_barra";
            txt_cdg_barra.Size = new Size(175, 23);
            txt_cdg_barra.TabIndex = 1;
            txt_cdg_barra.KeyUp += txt_cdg_barra_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(201, 56);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Cód. Barras";
            // 
            // txt_categoria
            // 
            txt_categoria.Enabled = false;
            txt_categoria.ForeColor = Color.Black;
            txt_categoria.Location = new Point(83, 126);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(100, 23);
            txt_categoria.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(83, 108);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Categoria";
            // 
            // txt_qtd
            // 
            txt_qtd.BackColor = Color.White;
            txt_qtd.Location = new Point(391, 74);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(62, 23);
            txt_qtd.TabIndex = 2;
            txt_qtd.KeyPress += txt_qtd_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(382, 56);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 8;
            label5.Text = "Quantidade";
            // 
            // txt_unidade
            // 
            txt_unidade.Enabled = false;
            txt_unidade.ForeColor = Color.Black;
            txt_unidade.Location = new Point(391, 126);
            txt_unidade.Name = "txt_unidade";
            txt_unidade.Size = new Size(62, 23);
            txt_unidade.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(391, 108);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "Unidade";
            // 
            // txt_preco_venda
            // 
            txt_preco_venda.Enabled = false;
            txt_preco_venda.ForeColor = Color.Black;
            txt_preco_venda.Location = new Point(83, 181);
            txt_preco_venda.Name = "txt_preco_venda";
            txt_preco_venda.Size = new Size(100, 23);
            txt_preco_venda.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(83, 163);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 12;
            label7.Text = "Preço venda";
            // 
            // txt_fornecedor
            // 
            txt_fornecedor.Enabled = false;
            txt_fornecedor.ForeColor = Color.Black;
            txt_fornecedor.Location = new Point(201, 181);
            txt_fornecedor.Name = "txt_fornecedor";
            txt_fornecedor.Size = new Size(252, 23);
            txt_fornecedor.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(201, 163);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 14;
            label8.Text = "Fornecedor";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(182, 250);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 16;
            bt_add.Text = "Adicionar";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(277, 250);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(75, 23);
            bt_save.TabIndex = 17;
            bt_save.Text = "Salvar";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // FrmNewStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 314);
            Controls.Add(bt_save);
            Controls.Add(bt_add);
            Controls.Add(txt_fornecedor);
            Controls.Add(label8);
            Controls.Add(txt_preco_venda);
            Controls.Add(label7);
            Controls.Add(txt_unidade);
            Controls.Add(label6);
            Controls.Add(txt_qtd);
            Controls.Add(label5);
            Controls.Add(txt_categoria);
            Controls.Add(label4);
            Controls.Add(txt_cdg_barra);
            Controls.Add(label3);
            Controls.Add(txt_nome);
            Controls.Add(label2);
            Controls.Add(txt_produto);
            Controls.Add(label1);
            Name = "FrmNewStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar estoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public Button bt_add;
        public Button bt_save;
        public TextBox txt_produto;
        public TextBox txt_nome;
        public TextBox txt_cdg_barra;
        public TextBox txt_categoria;
        public TextBox txt_qtd;
        public TextBox txt_unidade;
        public TextBox txt_preco_venda;
        public TextBox txt_fornecedor;
    }
}