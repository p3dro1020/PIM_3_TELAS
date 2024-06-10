namespace TelaLogin.FormsSubMenu
{
    partial class FrmNewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewEmployee));
            label7 = new Label();
            txt_senha = new TextBox();
            label6 = new Label();
            txt_usuario = new TextBox();
            label5 = new Label();
            txt_email = new TextBox();
            bt_cancel = new Button();
            bt_save = new Button();
            bt_add = new Button();
            label2 = new Label();
            txt_nome = new TextBox();
            label1 = new Label();
            txt_cargo = new TextBox();
            label4 = new Label();
            txt_acesso = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_salario = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(382, 120);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 49;
            label7.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(382, 138);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(165, 23);
            txt_senha.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(212, 120);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 47;
            label6.Text = "Usuário";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(212, 138);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(164, 23);
            txt_usuario.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(277, 70);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 44;
            label5.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(277, 88);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(270, 23);
            txt_email.TabIndex = 3;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(203, 273);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(75, 23);
            bt_cancel.TabIndex = 10;
            bt_cancel.Text = "Cancelar";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(121, 273);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(75, 23);
            bt_save.TabIndex = 9;
            bt_save.Text = "Salvar";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(39, 273);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 8;
            bt_add.Text = "Adicionar";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 23);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 32;
            label2.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(39, 41);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(508, 23);
            txt_nome.TabIndex = 1;
            txt_nome.KeyPress += txt_nome_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 70);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 30;
            label1.Text = "Cargo";
            // 
            // txt_cargo
            // 
            txt_cargo.Location = new Point(39, 88);
            txt_cargo.Name = "txt_cargo";
            txt_cargo.Size = new Size(232, 23);
            txt_cargo.TabIndex = 2;
            txt_cargo.KeyPress += txt_cargo_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(212, 168);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 56;
            label4.Text = "Nível acesso";
            // 
            // txt_acesso
            // 
            txt_acesso.Location = new Point(212, 186);
            txt_acesso.Name = "txt_acesso";
            txt_acesso.Size = new Size(45, 23);
            txt_acesso.TabIndex = 7;
            txt_acesso.KeyPress += txt_acesso_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 190);
            label8.Name = "label8";
            label8.Size = new Size(230, 15);
            label8.TabIndex = 57;
            label8.Text = "Nível  1 - Acesso somente a tela de vendas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(267, 205);
            label9.Name = "label9";
            label9.Size = new Size(140, 15);
            label9.TabIndex = 58;
            label9.Text = "Nível  2 - Somente leitura";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(267, 220);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 59;
            label10.Text = "Nível  3 - Acesso total";
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(39, 138);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(167, 23);
            txt_salario.TabIndex = 4;
            txt_salario.KeyPress += txt_salario_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(39, 120);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 61;
            label11.Text = "Salário";
            // 
            // FrmNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 308);
            Controls.Add(txt_salario);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txt_acesso);
            Controls.Add(txt_cargo);
            Controls.Add(label7);
            Controls.Add(txt_senha);
            Controls.Add(label6);
            Controls.Add(txt_usuario);
            Controls.Add(label5);
            Controls.Add(txt_email);
            Controls.Add(bt_cancel);
            Controls.Add(bt_save);
            Controls.Add(bt_add);
            Controls.Add(label2);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        public TextBox txt_senha;
        private Label label6;
        public TextBox txt_usuario;
        private Label label5;
        public TextBox txt_email;
        public Button bt_save;
        public Button bt_add;
        private Label label2;
        public TextBox txt_nome;
        private Label label1;
        public TextBox txt_cargo;
        private Label label4;
        public TextBox txt_acesso;
        private Label label8;
        private Label label9;
        private Label label10;
        public Button bt_cancel;
        public TextBox txt_salario;
        public Label label11;
    }
}