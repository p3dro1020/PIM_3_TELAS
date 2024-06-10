namespace TelaPIM
{
    partial class FrmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployees));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            bt_adicionar = new Button();
            bt_listAll = new Button();
            txt_search = new TextBox();
            label1 = new Label();
            bt_add = new Button();
            dgv_employe = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            salario = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            acesso = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_employe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(bt_adicionar);
            panel1.Controls.Add(bt_listAll);
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bt_add);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 523);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 75);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(264, 25);
            button1.Name = "button1";
            button1.Size = new Size(37, 31);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            // 
            // bt_adicionar
            // 
            bt_adicionar.Anchor = AnchorStyles.None;
            bt_adicionar.BackColor = Color.Transparent;
            bt_adicionar.Cursor = Cursors.Hand;
            bt_adicionar.FlatStyle = FlatStyle.Flat;
            bt_adicionar.ForeColor = Color.Transparent;
            bt_adicionar.Image = (Image)resources.GetObject("bt_adicionar.Image");
            bt_adicionar.Location = new Point(857, 25);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(34, 31);
            bt_adicionar.TabIndex = 13;
            bt_adicionar.UseVisualStyleBackColor = false;
            bt_adicionar.Click += bt_adicionar_Click;
            // 
            // bt_listAll
            // 
            bt_listAll.Anchor = AnchorStyles.None;
            bt_listAll.BackColor = Color.Transparent;
            bt_listAll.Cursor = Cursors.Hand;
            bt_listAll.FlatStyle = FlatStyle.Flat;
            bt_listAll.ForeColor = Color.Transparent;
            bt_listAll.Image = (Image)resources.GetObject("bt_listAll.Image");
            bt_listAll.Location = new Point(12, 25);
            bt_listAll.Name = "bt_listAll";
            bt_listAll.Size = new Size(37, 31);
            bt_listAll.TabIndex = 10;
            bt_listAll.UseVisualStyleBackColor = false;
            bt_listAll.Click += bt_listAll_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(120, 29);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(137, 23);
            txt_search.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(56, 33);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Pesquisar";
            // 
            // bt_add
            // 
            bt_add.Anchor = AnchorStyles.None;
            bt_add.BackColor = Color.Sienna;
            bt_add.Cursor = Cursors.Hand;
            bt_add.FlatStyle = FlatStyle.Flat;
            bt_add.ForeColor = Color.Sienna;
            bt_add.Image = (Image)resources.GetObject("bt_add.Image");
            bt_add.Location = new Point(1208, 9);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(34, 31);
            bt_add.TabIndex = 6;
            bt_add.UseVisualStyleBackColor = true;
            // 
            // dgv_employe
            // 
            dgv_employe.AllowUserToAddRows = false;
            dgv_employe.BackgroundColor = Color.White;
            dgv_employe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_employe.Columns.AddRange(new DataGridViewColumn[] { id, name, cargo, mail, salario, user, password, acesso, edit, delete });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_employe.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_employe.Dock = DockStyle.Fill;
            dgv_employe.Location = new Point(0, 0);
            dgv_employe.Name = "dgv_employe";
            dgv_employe.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Fuchsia;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_employe.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_employe.RowHeadersVisible = false;
            dgv_employe.Size = new Size(903, 523);
            dgv_employe.TabIndex = 2;
            dgv_employe.CellContentClick += dgv_employe_CellContentClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "Cód.";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 57;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nome";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // cargo
            // 
            cargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cargo.HeaderText = "Cargo";
            cargo.Name = "cargo";
            cargo.ReadOnly = true;
            cargo.Width = 64;
            // 
            // mail
            // 
            mail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mail.HeaderText = "Email";
            mail.Name = "mail";
            mail.ReadOnly = true;
            mail.Width = 61;
            // 
            // salario
            // 
            salario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            salario.HeaderText = "Salário";
            salario.Name = "salario";
            salario.ReadOnly = true;
            salario.Width = 67;
            // 
            // user
            // 
            user.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            user.HeaderText = "Usuário";
            user.Name = "user";
            user.ReadOnly = true;
            user.Width = 72;
            // 
            // password
            // 
            password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            password.HeaderText = "Senha";
            password.Name = "password";
            password.ReadOnly = true;
            password.Width = 64;
            // 
            // acesso
            // 
            acesso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            acesso.HeaderText = "Acesso";
            acesso.Name = "acesso";
            acesso.ReadOnly = true;
            acesso.Width = 69;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit.HeaderText = "";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Width = 5;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            delete.HeaderText = "";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Width = 5;
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(903, 598);
            Controls.Add(dgv_employe);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployees";
            Text = "FrmEmployees";
            Load += FrmEmployees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_employe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_listAll;
        private TextBox txt_search;
        private Label label1;
        private Button bt_add;
        private DataGridView dgv_employe;
        private Button bt_adicionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn cargo;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn salario;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn acesso;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private Button button1;
    }
}