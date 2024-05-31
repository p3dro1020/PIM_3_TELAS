namespace TelaLogin.FormsSubMenu
{
    partial class FrmPhoneSupplier
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
            txt_fornecedorNome = new Label();
            lb_phone = new ListBox();
            txt_nums = new MaskedTextBox();
            bt_add = new Button();
            bt_save = new Button();
            bt_delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Fornecedor:";
            // 
            // txt_fornecedorNome
            // 
            txt_fornecedorNome.AutoSize = true;
            txt_fornecedorNome.Location = new Point(98, 24);
            txt_fornecedorNome.Name = "txt_fornecedorNome";
            txt_fornecedorNome.Size = new Size(0, 15);
            txt_fornecedorNome.TabIndex = 1;
            // 
            // lb_phone
            // 
            lb_phone.FormattingEnabled = true;
            lb_phone.ItemHeight = 15;
            lb_phone.Location = new Point(22, 73);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(161, 139);
            lb_phone.TabIndex = 2;
            lb_phone.SelectedIndexChanged += lb_phone_SelectedIndexChanged;
            // 
            // txt_nums
            // 
            txt_nums.Location = new Point(225, 73);
            txt_nums.Mask = "(00) 00000-0000";
            txt_nums.Name = "txt_nums";
            txt_nums.Size = new Size(126, 23);
            txt_nums.TabIndex = 3;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(225, 112);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(126, 23);
            bt_add.TabIndex = 4;
            bt_add.Text = "Adicionar";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(225, 151);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(126, 23);
            bt_save.TabIndex = 5;
            bt_save.Text = "Salvar";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(225, 189);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(126, 23);
            bt_delete.TabIndex = 6;
            bt_delete.Text = "Remover";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // FrmPhoneSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 285);
            Controls.Add(bt_delete);
            Controls.Add(bt_save);
            Controls.Add(bt_add);
            Controls.Add(txt_nums);
            Controls.Add(lb_phone);
            Controls.Add(txt_fornecedorNome);
            Controls.Add(label1);
            Name = "FrmPhoneSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de telefones";
            Load += FrmPhoneSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lb_phone;
        private MaskedTextBox txt_nums;
        private Button bt_add;
        private Button bt_save;
        private Button bt_delete;
        public Label txt_fornecedorNome;
    }
}