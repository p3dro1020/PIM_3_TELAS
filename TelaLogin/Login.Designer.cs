namespace TelaLogin
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureLogin = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            linkPassword = new LinkLabel();
            btnLogin = new Button();
            labelUser = new Label();
            labelPassword = new Label();
            labelMadeBy = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureLogin
            // 
            pictureLogin.Image = (Image)resources.GetObject("pictureLogin.Image");
            pictureLogin.Location = new Point(-88, -22);
            pictureLogin.Name = "pictureLogin";
            pictureLogin.Size = new Size(614, 540);
            pictureLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogin.TabIndex = 0;
            pictureLogin.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Cursor = Cursors.IBeam;
            txtUser.Location = new Point(557, 245);
            txtUser.MaxLength = 20;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(132, 23);
            txtUser.TabIndex = 1;
            txtUser.WordWrap = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(557, 298);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(132, 23);
            txtPassword.TabIndex = 2;
            txtPassword.WordWrap = false;
            // 
            // linkPassword
            // 
            linkPassword.AutoSize = true;
            linkPassword.Location = new Point(579, 384);
            linkPassword.Name = "linkPassword";
            linkPassword.Size = new Size(90, 15);
            linkPassword.TabIndex = 4;
            linkPassword.TabStop = true;
            linkPassword.Text = "Esqueci a senha";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(553, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(554, 222);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(59, 16);
            labelUser.TabIndex = 8;
            labelUser.Text = "Usuário:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(554, 277);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(52, 16);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Senha:";
            // 
            // labelMadeBy
            // 
            labelMadeBy.AutoSize = true;
            labelMadeBy.Location = new Point(557, 484);
            labelMadeBy.Name = "labelMadeBy";
            labelMadeBy.Size = new Size(127, 15);
            labelMadeBy.TabIndex = 10;
            labelMadeBy.Text = "Feito por: BYTEFUTURE";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(527, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 164);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(753, 511);
            Controls.Add(pictureBox2);
            Controls.Add(labelMadeBy);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(btnLogin);
            Controls.Add(linkPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisionFarm";
            ((System.ComponentModel.ISupportInitialize)pictureLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogin;
        private TextBox txtUser;
        private TextBox txtPassword;
        private LinkLabel linkPassword;
        private Button btnLogin;
        private Label labelUser;
        private Label labelPassword;
        private Label labelMadeBy;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox pictureBox2;
    }
}
