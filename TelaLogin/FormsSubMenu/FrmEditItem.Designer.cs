namespace TelaLogin.FormsSubMenu
{
    partial class FrmEditItem
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
            txt_preco_unico = new TextBox();
            label2 = new Label();
            txt_qtd = new TextBox();
            label3 = new Label();
            txt_valor_total = new TextBox();
            label4 = new Label();
            bt_excluir = new Button();
            bt_edit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // txt_produto
            // 
            txt_produto.BackColor = Color.White;
            txt_produto.Enabled = false;
            txt_produto.ForeColor = Color.Black;
            txt_produto.Location = new Point(25, 50);
            txt_produto.Name = "txt_produto";
            txt_produto.Size = new Size(100, 23);
            txt_produto.TabIndex = 1;
            // 
            // txt_preco_unico
            // 
            txt_preco_unico.BackColor = Color.White;
            txt_preco_unico.Enabled = false;
            txt_preco_unico.ForeColor = Color.Black;
            txt_preco_unico.Location = new Point(142, 50);
            txt_preco_unico.Name = "txt_preco_unico";
            txt_preco_unico.Size = new Size(100, 23);
            txt_preco_unico.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(142, 32);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Preço Único";
            // 
            // txt_qtd
            // 
            txt_qtd.BackColor = Color.White;
            txt_qtd.Location = new Point(25, 104);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(100, 23);
            txt_qtd.TabIndex = 5;
            txt_qtd.TextChanged += txt_qtd_TextChanged;
            txt_qtd.KeyPress += txt_qtd_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 86);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade";
            // 
            // txt_valor_total
            // 
            txt_valor_total.BackColor = Color.White;
            txt_valor_total.Enabled = false;
            txt_valor_total.Location = new Point(142, 104);
            txt_valor_total.Name = "txt_valor_total";
            txt_valor_total.Size = new Size(100, 23);
            txt_valor_total.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(142, 86);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Valor total";
            // 
            // bt_excluir
            // 
            bt_excluir.Location = new Point(142, 189);
            bt_excluir.Name = "bt_excluir";
            bt_excluir.Size = new Size(75, 23);
            bt_excluir.TabIndex = 9;
            bt_excluir.Text = "Excluir";
            bt_excluir.UseVisualStyleBackColor = true;
            bt_excluir.Click += bt_excluir_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(50, 189);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(75, 23);
            bt_edit.TabIndex = 10;
            bt_edit.Text = "Editar";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // FrmEditItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 257);
            Controls.Add(bt_edit);
            Controls.Add(bt_excluir);
            Controls.Add(txt_valor_total);
            Controls.Add(label4);
            Controls.Add(txt_qtd);
            Controls.Add(label3);
            Controls.Add(txt_preco_unico);
            Controls.Add(label2);
            Controls.Add(txt_produto);
            Controls.Add(label1);
            Name = "FrmEditItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button bt_excluir;
        public Label label1;
        public TextBox txt_produto;
        public TextBox txt_preco_unico;
        public Label label2;
        public TextBox txt_qtd;
        public Label label3;
        public TextBox txt_valor_total;
        public Label label4;
        private Button bt_edit;
    }
}