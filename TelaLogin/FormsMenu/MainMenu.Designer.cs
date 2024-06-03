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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnProduction = new Button();
            btnSales = new Button();
            btnSuppliers = new Button();
            btnProducts = new Button();
            btnEmployees = new Button();
            btnHome = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panelForm = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            dataGridView3 = new DataGridView();
            cdg = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            qtdPlantacoes = new DataGridViewTextBoxColumn();
            datePlantio = new DataGridViewTextBoxColumn();
            dateColheitaEsperada = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label3 = new Label();
            dgv_colheitas = new DataGridView();
            item_colheita = new DataGridViewTextBoxColumn();
            qtdPes = new DataGridViewTextBoxColumn();
            dateColheita = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dgv_lastSale = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            item = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_colheitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_lastSale).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkOliveGreen;
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(pictureBox2);
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
            panelMenu.Size = new Size(220, 598);
            panelMenu.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(187, 514);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(131, 95);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(87, 513);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 113);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 533);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 83);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
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
            btnEmployees.BackColor = Color.DarkOliveGreen;
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
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 94);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 54);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 3;
            label5.Text = "Nível acesso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 26);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 2;
            label4.Text = "Usuário: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(pictureBox7);
            panelForm.Controls.Add(pictureBox6);
            panelForm.Controls.Add(pictureBox5);
            panelForm.Controls.Add(dataGridView3);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(dgv_colheitas);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(dgv_lastSale);
            panelForm.Controls.Add(label1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(220, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(903, 598);
            panelForm.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(45, 305);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(71, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(481, 44);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(75, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(45, 43);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { cdg, name, qtdPlantacoes, datePlantio, dateColheitaEsperada, status });
            dataGridView3.Location = new Point(45, 367);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.Size = new Size(820, 174);
            dataGridView3.TabIndex = 5;
            // 
            // cdg
            // 
            cdg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            cdg.DefaultCellStyle = dataGridViewCellStyle1;
            cdg.HeaderText = "Código";
            cdg.Name = "cdg";
            cdg.Width = 71;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nome";
            name.Name = "name";
            // 
            // qtdPlantacoes
            // 
            qtdPlantacoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtdPlantacoes.HeaderText = "Quantidade";
            qtdPlantacoes.Name = "qtdPlantacoes";
            qtdPlantacoes.Width = 94;
            // 
            // datePlantio
            // 
            datePlantio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datePlantio.HeaderText = "Data plantio";
            datePlantio.Name = "datePlantio";
            datePlantio.Width = 88;
            // 
            // dateColheitaEsperada
            // 
            dateColheitaEsperada.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateColheitaEsperada.HeaderText = "Data colheita esperada";
            dateColheitaEsperada.Name = "dateColheitaEsperada";
            dateColheitaEsperada.Width = 138;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            status.HeaderText = "Status";
            status.Name = "status";
            status.Width = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 320);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 4;
            label3.Text = "Plantações últimos 15 dias";
            // 
            // dgv_colheitas
            // 
            dgv_colheitas.BackgroundColor = Color.White;
            dgv_colheitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_colheitas.Columns.AddRange(new DataGridViewColumn[] { item_colheita, qtdPes, dateColheita });
            dgv_colheitas.Location = new Point(481, 108);
            dgv_colheitas.Name = "dgv_colheitas";
            dgv_colheitas.RowHeadersVisible = false;
            dgv_colheitas.Size = new Size(384, 174);
            dgv_colheitas.TabIndex = 3;
            // 
            // item_colheita
            // 
            item_colheita.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_colheita.HeaderText = "Item";
            item_colheita.Name = "item_colheita";
            // 
            // qtdPes
            // 
            qtdPes.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtdPes.HeaderText = "Quantidade Pés";
            qtdPes.Name = "qtdPes";
            qtdPes.Width = 106;
            // 
            // dateColheita
            // 
            dateColheita.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateColheita.HeaderText = "Data colheita";
            dateColheita.Name = "dateColheita";
            dateColheita.Width = 93;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(562, 59);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 2;
            label2.Text = "Próximas colheitas";
            // 
            // dgv_lastSale
            // 
            dgv_lastSale.BackgroundColor = Color.White;
            dgv_lastSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lastSale.Columns.AddRange(new DataGridViewColumn[] { date, item, valor, qtd });
            dgv_lastSale.Location = new Point(45, 108);
            dgv_lastSale.Name = "dgv_lastSale";
            dgv_lastSale.RowHeadersVisible = false;
            dgv_lastSale.Size = new Size(384, 174);
            dgv_lastSale.TabIndex = 1;
            // 
            // date
            // 
            date.HeaderText = "Data";
            date.Name = "date";
            date.Width = 70;
            // 
            // item
            // 
            item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item.HeaderText = "Item";
            item.Name = "item";
            // 
            // valor
            // 
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.Width = 50;
            // 
            // qtd
            // 
            qtd.HeaderText = "Quantidade";
            qtd.Name = "qtd";
            qtd.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 59);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Últimas vendas";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 598);
            Controls.Add(panelForm);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisionFarm";
            Closed += MainMenu_Closed;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_colheitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_lastSale).EndInit();
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
        private DataGridView dataGridView3;
        private Label label3;
        private DataGridView dgv_colheitas;
        private Label label2;
        private DataGridView dgv_lastSale;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn qtd;
        private Label label1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private DataGridViewTextBoxColumn item_colheita;
        private DataGridViewTextBoxColumn qtdPes;
        private DataGridViewTextBoxColumn dateColheita;
        private DataGridViewTextBoxColumn cdg;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn qtdPlantacoes;
        private DataGridViewTextBoxColumn datePlantio;
        private DataGridViewTextBoxColumn dateColheitaEsperada;
        private DataGridViewTextBoxColumn status;
    }
}
