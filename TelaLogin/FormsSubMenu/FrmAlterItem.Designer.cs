namespace TelaLogin.FormsSubMenu
{
    partial class FrmAlterItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterItem));
            bt_add = new Button();
            bt_save = new Button();
            bt_delete = new Button();
            txt_estoque_minimo = new TextBox();
            label10 = new Label();
            txt_lucro = new TextBox();
            label9 = new Label();
            txt_valor_venda = new TextBox();
            label8 = new Label();
            txt_porcentagem = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_preco_custo = new TextBox();
            label11 = new Label();
            txt_nome = new TextBox();
            label12 = new Label();
            txt_codigo_barras = new TextBox();
            label13 = new Label();
            txt_categoria = new TextBox();
            txt_fornecedor = new TextBox();
            cb_un = new TextBox();
            SuspendLayout();
            // 
            // bt_add
            // 
            bt_add.Location = new Point(27, 224);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 11;
            bt_add.Text = "Adicionar";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(108, 224);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(75, 23);
            bt_save.TabIndex = 12;
            bt_save.Text = "Salvar";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(189, 224);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 23);
            bt_delete.TabIndex = 13;
            bt_delete.Text = "Deletar";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // txt_estoque_minimo
            // 
            txt_estoque_minimo.Font = new Font("Segoe UI", 8.25F);
            txt_estoque_minimo.Location = new Point(27, 152);
            txt_estoque_minimo.Name = "txt_estoque_minimo";
            txt_estoque_minimo.Size = new Size(125, 22);
            txt_estoque_minimo.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label10.Location = new Point(27, 134);
            label10.Name = "label10";
            label10.Size = new Size(97, 13);
            label10.TabIndex = 41;
            label10.Text = "Estoque mínimo*";
            // 
            // txt_lucro
            // 
            txt_lucro.Enabled = false;
            txt_lucro.Font = new Font("Segoe UI", 8.25F);
            txt_lucro.Location = new Point(415, 99);
            txt_lucro.Name = "txt_lucro";
            txt_lucro.Size = new Size(94, 22);
            txt_lucro.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label9.Location = new Point(415, 81);
            label9.Name = "label9";
            label9.Size = new Size(41, 13);
            label9.TabIndex = 40;
            label9.Text = "Lucro*";
            // 
            // txt_valor_venda
            // 
            txt_valor_venda.Enabled = false;
            txt_valor_venda.Font = new Font("Segoe UI", 8.25F);
            txt_valor_venda.Location = new Point(310, 99);
            txt_valor_venda.Name = "txt_valor_venda";
            txt_valor_venda.Size = new Size(94, 22);
            txt_valor_venda.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label8.Location = new Point(310, 81);
            label8.Name = "label8";
            label8.Size = new Size(73, 13);
            label8.TabIndex = 39;
            label8.Text = "Valor venda*";
            // 
            // txt_porcentagem
            // 
            txt_porcentagem.Font = new Font("Segoe UI", 8.25F);
            txt_porcentagem.Location = new Point(203, 99);
            txt_porcentagem.Name = "txt_porcentagem";
            txt_porcentagem.Size = new Size(94, 22);
            txt_porcentagem.TabIndex = 6;
            txt_porcentagem.TextChanged += txt_porcentagem_TextChanged;
            txt_porcentagem.KeyPress += txt_porcentagem_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label7.Location = new Point(203, 81);
            label7.Name = "label7";
            label7.Size = new Size(81, 13);
            label7.TabIndex = 36;
            label7.Text = "Porcentagem*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label6.Location = new Point(166, 134);
            label6.Name = "label6";
            label6.Size = new Size(71, 13);
            label6.TabIndex = 34;
            label6.Text = "Fornecedor*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label5.Location = new Point(27, 81);
            label5.Name = "label5";
            label5.Size = new Size(29, 13);
            label5.TabIndex = 30;
            label5.Text = "UN*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label4.Location = new Point(373, 30);
            label4.Name = "label4";
            label4.Size = new Size(62, 13);
            label4.TabIndex = 27;
            label4.Text = "Categoria*";
            // 
            // txt_preco_custo
            // 
            txt_preco_custo.Font = new Font("Segoe UI", 8.25F);
            txt_preco_custo.Location = new Point(97, 99);
            txt_preco_custo.Name = "txt_preco_custo";
            txt_preco_custo.Size = new Size(94, 22);
            txt_preco_custo.TabIndex = 5;
            txt_preco_custo.TextChanged += txt_preco_custo_TextChanged;
            txt_preco_custo.KeyPress += txt_preco_custo_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label11.Location = new Point(97, 81);
            label11.Name = "label11";
            label11.Size = new Size(72, 13);
            label11.TabIndex = 25;
            label11.Text = "Preço custo*";
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 8.25F);
            txt_nome.Location = new Point(143, 48);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(215, 22);
            txt_nome.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label12.Location = new Point(143, 30);
            label12.Name = "label12";
            label12.Size = new Size(44, 13);
            label12.TabIndex = 21;
            label12.Text = "Nome*";
            // 
            // txt_codigo_barras
            // 
            txt_codigo_barras.Font = new Font("Segoe UI", 8.25F);
            txt_codigo_barras.Location = new Point(27, 48);
            txt_codigo_barras.Name = "txt_codigo_barras";
            txt_codigo_barras.Size = new Size(100, 22);
            txt_codigo_barras.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label13.Location = new Point(27, 30);
            label13.Name = "label13";
            label13.Size = new Size(71, 13);
            label13.TabIndex = 19;
            label13.Text = "Cód. Barras*";
            // 
            // txt_categoria
            // 
            txt_categoria.Font = new Font("Segoe UI", 8.25F);
            txt_categoria.Location = new Point(373, 48);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(136, 22);
            txt_categoria.TabIndex = 3;
            // 
            // txt_fornecedor
            // 
            txt_fornecedor.Enabled = false;
            txt_fornecedor.Font = new Font("Segoe UI", 8.25F);
            txt_fornecedor.Location = new Point(166, 152);
            txt_fornecedor.Name = "txt_fornecedor";
            txt_fornecedor.Size = new Size(343, 22);
            txt_fornecedor.TabIndex = 10;
            // 
            // cb_un
            // 
            cb_un.Location = new Point(27, 98);
            cb_un.Name = "cb_un";
            cb_un.Size = new Size(60, 23);
            cb_un.TabIndex = 4;
            // 
            // FrmAlterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 270);
            Controls.Add(cb_un);
            Controls.Add(txt_fornecedor);
            Controls.Add(txt_categoria);
            Controls.Add(txt_estoque_minimo);
            Controls.Add(label10);
            Controls.Add(txt_lucro);
            Controls.Add(label9);
            Controls.Add(txt_valor_venda);
            Controls.Add(label8);
            Controls.Add(txt_porcentagem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_preco_custo);
            Controls.Add(label11);
            Controls.Add(txt_nome);
            Controls.Add(label12);
            Controls.Add(txt_codigo_barras);
            Controls.Add(label13);
            Controls.Add(bt_delete);
            Controls.Add(bt_save);
            Controls.Add(bt_add);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAlterItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button bt_add;
        public Button bt_save;
        public Button bt_delete;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label12;
        private Label label13;
        public TextBox txt_codigo_barras;
        public TextBox txt_estoque_minimo;
        public TextBox txt_lucro;
        public TextBox txt_valor_venda;
        public TextBox txt_porcentagem;
        public TextBox txt_preco_custo;
        public TextBox txt_nome;
        public TextBox txt_categoria;
        public TextBox txt_fornecedor;
        public TextBox cb_un;
    }
}