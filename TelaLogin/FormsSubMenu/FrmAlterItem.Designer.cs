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
            label1 = new Label();
            txt_nomeItem = new TextBox();
            txt_un = new TextBox();
            label2 = new Label();
            txt_preco = new TextBox();
            label3 = new Label();
            bt_add = new Button();
            bt_save = new Button();
            bt_delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txt_nomeItem
            // 
            txt_nomeItem.Location = new Point(45, 53);
            txt_nomeItem.Name = "txt_nomeItem";
            txt_nomeItem.Size = new Size(240, 23);
            txt_nomeItem.TabIndex = 1;
            // 
            // txt_un
            // 
            txt_un.Location = new Point(45, 112);
            txt_un.Name = "txt_un";
            txt_un.Size = new Size(113, 23);
            txt_un.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Unidade";
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(171, 112);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(114, 23);
            txt_preco.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 94);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(45, 162);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 6;
            bt_add.Text = "Adicionar";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(129, 162);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(75, 23);
            bt_save.TabIndex = 7;
            bt_save.Text = "Salvar";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(210, 162);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 23);
            bt_delete.TabIndex = 8;
            bt_delete.Text = "Deletar";
            bt_delete.UseVisualStyleBackColor = true;
            // 
            // FrmAlterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 217);
            Controls.Add(bt_delete);
            Controls.Add(bt_save);
            Controls.Add(bt_add);
            Controls.Add(txt_preco);
            Controls.Add(label3);
            Controls.Add(txt_un);
            Controls.Add(label2);
            Controls.Add(txt_nomeItem);
            Controls.Add(label1);
            Name = "FrmAlterItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txt_nomeItem;
        public TextBox txt_un;
        public TextBox txt_preco;
        public Button bt_add;
        public Button bt_save;
        public Button bt_delete;
    }
}