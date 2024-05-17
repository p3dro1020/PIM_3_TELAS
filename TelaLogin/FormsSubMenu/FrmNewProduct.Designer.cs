namespace TelaLogin.FormsMenu
{
    partial class FrmProductManagement
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
            cb_hortalica = new ComboBox();
            dt_plantio = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txt_qtd = new TextBox();
            label4 = new Label();
            dt_colheita = new DateTimePicker();
            txt_days = new Label();
            bt_addNewPlantio = new Button();
            bt_cancel = new Button();
            bt_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Hortaliça:";
            // 
            // cb_hortalica
            // 
            cb_hortalica.FormattingEnabled = true;
            cb_hortalica.Items.AddRange(new object[] { "Alface", "Berinjela", "Brócolis", "Cebola", "Couve", "Couve Flor", "Morango", "Tomate", "Repolho", "Pimentão" });
            cb_hortalica.Location = new Point(125, 53);
            cb_hortalica.Name = "cb_hortalica";
            cb_hortalica.Size = new Size(121, 23);
            cb_hortalica.TabIndex = 1;
            cb_hortalica.SelectedIndexChanged += cb_hortalica_SelectedIndexChanged;
            // 
            // dt_plantio
            // 
            dt_plantio.Format = DateTimePickerFormat.Short;
            dt_plantio.Location = new Point(125, 101);
            dt_plantio.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dt_plantio.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dt_plantio.Name = "dt_plantio";
            dt_plantio.Size = new Size(121, 23);
            dt_plantio.TabIndex = 2;
            dt_plantio.Value = new DateTime(2024, 5, 16, 18, 18, 49, 0);
            dt_plantio.ValueChanged += dt_plantio_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 107);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Data plantio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 160);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade pés:";
            // 
            // txt_qtd
            // 
            txt_qtd.Location = new Point(125, 157);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(121, 23);
            txt_qtd.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 56);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 6;
            label4.Text = "Data colheita esperada:";
            // 
            // dt_colheita
            // 
            dt_colheita.Enabled = false;
            dt_colheita.Format = DateTimePickerFormat.Short;
            dt_colheita.Location = new Point(404, 53);
            dt_colheita.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dt_colheita.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dt_colheita.Name = "dt_colheita";
            dt_colheita.Size = new Size(121, 23);
            dt_colheita.TabIndex = 4;
            dt_colheita.Value = new DateTime(2024, 5, 16, 18, 18, 49, 0);
            // 
            // txt_days
            // 
            txt_days.AutoSize = true;
            txt_days.Location = new Point(293, 101);
            txt_days.Name = "txt_days";
            txt_days.Size = new Size(105, 15);
            txt_days.TabIndex = 7;
            txt_days.Text = "Dias até a colheita:";
            // 
            // bt_addNewPlantio
            // 
            bt_addNewPlantio.Location = new Point(142, 222);
            bt_addNewPlantio.Name = "bt_addNewPlantio";
            bt_addNewPlantio.Size = new Size(75, 23);
            bt_addNewPlantio.TabIndex = 5;
            bt_addNewPlantio.Text = "Adicionar";
            bt_addNewPlantio.UseVisualStyleBackColor = true;
            bt_addNewPlantio.Click += bt_addNewPlantio_Click;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(334, 222);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(75, 23);
            bt_cancel.TabIndex = 7;
            bt_cancel.Text = "Cancelar";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(239, 222);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(75, 23);
            bt_save.TabIndex = 6;
            bt_save.Text = "Salvar";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // FrmProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 280);
            Controls.Add(bt_save);
            Controls.Add(bt_cancel);
            Controls.Add(bt_addNewPlantio);
            Controls.Add(txt_days);
            Controls.Add(label4);
            Controls.Add(dt_colheita);
            Controls.Add(txt_qtd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dt_plantio);
            Controls.Add(cb_hortalica);
            Controls.Add(label1);
            Name = "FrmProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plantação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dt_colheita;
        private Label txt_days;
        public Button bt_save;
        public Button bt_addNewPlantio;
        public Button bt_cancel;
        public ComboBox cb_hortalica;
        public DateTimePicker dt_plantio;
        public TextBox txt_qtd;
    }
}