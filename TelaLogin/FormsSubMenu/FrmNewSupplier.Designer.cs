namespace TelaLogin.FormsSubMenu
{
    partial class FrmNewSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewSupplier));
            label1 = new Label();
            txt_razaoSocial = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_endereco = new TextBox();
            bt_add = new Button();
            bt_save = new Button();
            bt_cancel = new Button();
            label5 = new Label();
            txt_nomeFantasia = new TextBox();
            label6 = new Label();
            txt_complemento = new TextBox();
            label7 = new Label();
            txt_bairro = new TextBox();
            label8 = new Label();
            txt_uf = new ComboBox();
            label9 = new Label();
            txt_cidade = new TextBox();
            label10 = new Label();
            txt_num = new TextBox();
            label12 = new Label();
            txt_email = new TextBox();
            bt_delete = new Button();
            txt_cnpj = new MaskedTextBox();
            txt_cep = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 62);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "CNPJ";
            // 
            // txt_razaoSocial
            // 
            txt_razaoSocial.Location = new Point(39, 33);
            txt_razaoSocial.Name = "txt_razaoSocial";
            txt_razaoSocial.Size = new Size(508, 23);
            txt_razaoSocial.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 15);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Razão social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 112);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 112);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Endereço";
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(135, 130);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(198, 23);
            txt_endereco.TabIndex = 5;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(94, 312);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 12;
            bt_add.Text = "Adicionar";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(187, 312);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(75, 23);
            bt_save.TabIndex = 13;
            bt_save.Text = "Salvar";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(277, 312);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(75, 23);
            bt_cancel.TabIndex = 14;
            bt_cancel.Text = "Cancelar";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(220, 62);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 12;
            label5.Text = "Nome fantasia";
            // 
            // txt_nomeFantasia
            // 
            txt_nomeFantasia.Location = new Point(220, 80);
            txt_nomeFantasia.Name = "txt_nomeFantasia";
            txt_nomeFantasia.Size = new Size(327, 23);
            txt_nomeFantasia.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(339, 112);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 14;
            label6.Text = "Complemento";
            // 
            // txt_complemento
            // 
            txt_complemento.Location = new Point(339, 130);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(208, 23);
            txt_complemento.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 163);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 16;
            label7.Text = "Bairro";
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(39, 181);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(186, 23);
            txt_bairro.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(231, 163);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 18;
            label8.Text = "UF";
            // 
            // txt_uf
            // 
            txt_uf.FormattingEnabled = true;
            txt_uf.Location = new Point(231, 181);
            txt_uf.Name = "txt_uf";
            txt_uf.Size = new Size(43, 23);
            txt_uf.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(280, 163);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 21;
            label9.Text = "Cidade";
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(280, 181);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(219, 23);
            txt_cidade.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(505, 163);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 23;
            label10.Text = "Nº";
            // 
            // txt_num
            // 
            txt_num.Location = new Point(505, 181);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(42, 23);
            txt_num.TabIndex = 10;
            txt_num.KeyPress += txt_num_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(39, 219);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 27;
            label12.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(39, 237);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(508, 23);
            txt_email.TabIndex = 11;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(368, 312);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 23);
            bt_delete.TabIndex = 15;
            bt_delete.Text = "Deletar";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // txt_cnpj
            // 
            txt_cnpj.Location = new Point(39, 80);
            txt_cnpj.Mask = "00.000.000/0000-00";
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(175, 23);
            txt_cnpj.TabIndex = 28;
            // 
            // txt_cep
            // 
            txt_cep.Location = new Point(39, 130);
            txt_cep.Mask = "00000-000";
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(90, 23);
            txt_cep.TabIndex = 29;
            // 
            // FrmNewSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 394);
            Controls.Add(txt_cep);
            Controls.Add(txt_cnpj);
            Controls.Add(bt_delete);
            Controls.Add(label12);
            Controls.Add(txt_email);
            Controls.Add(label10);
            Controls.Add(txt_num);
            Controls.Add(label9);
            Controls.Add(txt_cidade);
            Controls.Add(txt_uf);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_bairro);
            Controls.Add(label6);
            Controls.Add(txt_complemento);
            Controls.Add(label5);
            Controls.Add(txt_nomeFantasia);
            Controls.Add(bt_cancel);
            Controls.Add(bt_save);
            Controls.Add(bt_add);
            Controls.Add(label4);
            Controls.Add(txt_endereco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_razaoSocial);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmNewSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Button bt_cancel;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        public Button bt_add;
        public Button bt_save;
        public TextBox txt_razaoSocial;
        public TextBox txt_endereco;
        public TextBox txt_nomeFantasia;
        public TextBox txt_complemento;
        public TextBox txt_bairro;
        public ComboBox txt_uf;
        public TextBox txt_cidade;
        public TextBox txt_num;
        public TextBox txt_email;
        public Button bt_delete;
        public MaskedTextBox txt_cnpj;
        public MaskedTextBox txt_cep;
        public Label label3;
    }
}