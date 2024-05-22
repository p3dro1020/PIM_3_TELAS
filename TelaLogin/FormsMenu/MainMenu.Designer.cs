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
            dataGridView3 = new DataGridView();
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
            cdg = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            qtdPlantacoes = new DataGridViewTextBoxColumn();
            datePlantio = new DataGridViewTextBoxColumn();
            dateColheitaEsperada = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_colheitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_lastSale).BeginInit();
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
            panelMenu.Size = new Size(220, 598);
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
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { cdg, name, qtdPlantacoes, datePlantio, dateColheitaEsperada, status });
            dataGridView3.Location = new Point(45, 334);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(820, 174);
            dataGridView3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 304);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 4;
            label3.Text = "Plantações últimos 15 dias";
            // 
            // dgv_colheitas
            // 
            dgv_colheitas.BackgroundColor = Color.White;
            dgv_colheitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_colheitas.Columns.AddRange(new DataGridViewColumn[] { item_colheita, qtdPes, dateColheita });
            dgv_colheitas.Location = new Point(481, 58);
            dgv_colheitas.Name = "dgv_colheitas";
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
            label2.Location = new Point(481, 28);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Próximas colheitas";
            // 
            // dgv_lastSale
            // 
            dgv_lastSale.BackgroundColor = Color.White;
            dgv_lastSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lastSale.Columns.AddRange(new DataGridViewColumn[] { date, item, valor, qtd });
            dgv_lastSale.Location = new Point(45, 58);
            dgv_lastSale.Name = "dgv_lastSale";
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
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Últimas vendas";
            // 
            // cdg
            // 
            cdg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            datePlantio.Width = 96;
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
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 598);
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
            panelForm.PerformLayout();
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
