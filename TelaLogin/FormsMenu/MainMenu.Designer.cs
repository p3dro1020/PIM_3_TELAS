namespace TelaPIM
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelMenu = new Panel();
            btnProduction = new Button();
            btnSales = new Button();
            btnSuppliers = new Button();
            btnProducts = new Button();
            btnEmployees = new Button();
            btnHome = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelForm = new Panel();
            labelFormulario = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Sienna;
            panelMenu.Controls.Add(btnProduction);
            panelMenu.Controls.Add(btnSales);
            panelMenu.Controls.Add(btnSuppliers);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(btnEmployees);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 509);
            panelMenu.TabIndex = 0;
            // 
            // btnProduction
            // 
            btnProduction.Dock = DockStyle.Top;
            btnProduction.FlatAppearance.BorderSize = 0;
            btnProduction.FlatStyle = FlatStyle.Flat;
            btnProduction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProduction.ForeColor = Color.White;
            btnProduction.Image = (Image)resources.GetObject("btnProduction.Image");
            btnProduction.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduction.Location = new Point(0, 439);
            btnProduction.Name = "btnProduction";
            btnProduction.Padding = new Padding(10, 0, 0, 0);
            btnProduction.Size = new Size(220, 69);
            btnProduction.TabIndex = 6;
            btnProduction.Text = "Produção";
            btnProduction.TextAlign = ContentAlignment.MiddleLeft;
            btnProduction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduction.UseVisualStyleBackColor = true;
            btnProduction.Click += btnProduction_Click;
            // 
            // btnSales
            // 
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Image = (Image)resources.GetObject("btnSales.Image");
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 370);
            btnSales.Name = "btnSales";
            btnSales.Padding = new Padding(10, 0, 0, 0);
            btnSales.Size = new Size(220, 69);
            btnSales.TabIndex = 5;
            btnSales.Text = "Vendas";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Image = (Image)resources.GetObject("btnSuppliers.Image");
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(0, 301);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Padding = new Padding(10, 0, 0, 0);
            btnSuppliers.Size = new Size(220, 69);
            btnSuppliers.TabIndex = 4;
            btnSuppliers.Text = "Fornecedores";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 232);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(10, 0, 0, 0);
            btnProducts.Size = new Size(220, 69);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Produtos";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Sienna;
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Image = (Image)resources.GetObject("btnEmployees.Image");
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 163);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(10, 0, 0, 0);
            btnEmployees.Size = new Size(220, 69);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Funcionários";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 94);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(220, 69);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 94);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(labelFormulario);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(220, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(584, 509);
            panelForm.TabIndex = 1;
            // 
            // labelFormulario
            // 
            labelFormulario.Location = new Point(136, 38);
            labelFormulario.Name = "labelFormulario";
            labelFormulario.Size = new Size(196, 23);
            labelFormulario.TabIndex = 0;
            labelFormulario.Text = "Formulário Home";
            labelFormulario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 509);
            Controls.Add(panelForm);
            Controls.Add(panelMenu);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Closed += MainMenu_Closed;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnHome;
        private Button btnProducts;
        private Button btnEmployees;
        private Button btnSales;
        private Button btnSuppliers;
        private Button btnProduction;
        private Panel panelForm;
        private Label labelFormulario;
    }
}
