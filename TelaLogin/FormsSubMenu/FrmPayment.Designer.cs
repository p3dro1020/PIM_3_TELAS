namespace TelaLogin.FormsSubMenu
{
    partial class FrmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayment));
            label1 = new Label();
            txt_valor_total = new TextBox();
            txt_desconto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cb_pagamento = new ComboBox();
            label6 = new Label();
            label12 = new Label();
            label13 = new Label();
            txt_simulacao_dinheiro = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            bt_confirmar = new Button();
            label11 = new Label();
            txt_simulacao_credito3x = new Label();
            txt_simulacao_credito2x = new Label();
            txt_simulacao_credito_avista = new Label();
            txt_simulacao_debito = new Label();
            txt_simulacao_pix = new Label();
            cb_desconto = new CheckBox();
            txt_acrescimo = new TextBox();
            label18 = new Label();
            txt_valorFinal = new TextBox();
            label23 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(301, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor inicial";
            // 
            // txt_valor_total
            // 
            txt_valor_total.Enabled = false;
            txt_valor_total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_valor_total.ForeColor = Color.Black;
            txt_valor_total.Location = new Point(301, 37);
            txt_valor_total.Name = "txt_valor_total";
            txt_valor_total.Size = new Size(100, 23);
            txt_valor_total.TabIndex = 1;
            // 
            // txt_desconto
            // 
            txt_desconto.Enabled = false;
            txt_desconto.ForeColor = Color.Black;
            txt_desconto.Location = new Point(301, 128);
            txt_desconto.Name = "txt_desconto";
            txt_desconto.Size = new Size(100, 23);
            txt_desconto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(301, 110);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Desconto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 19);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 8;
            label5.Text = "Método de pagamento";
            // 
            // cb_pagamento
            // 
            cb_pagamento.ForeColor = Color.Black;
            cb_pagamento.FormattingEnabled = true;
            cb_pagamento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartão débito", "Cartão crédito À vista", "Cartão crédito 2x.", "Cartão crédito 3x." });
            cb_pagamento.Location = new Point(23, 37);
            cb_pagamento.Name = "cb_pagamento";
            cb_pagamento.Size = new Size(129, 23);
            cb_pagamento.TabIndex = 9;
            cb_pagamento.SelectedIndexChanged += cb_pagamento_SelectedIndexChanged;
            cb_pagamento.KeyPress += cb_pagamento_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(23, 92);
            label6.Name = "label6";
            label6.Size = new Size(149, 15);
            label6.TabIndex = 10;
            label6.Text = "Simulação de Pagamento:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(23, 136);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 16;
            label12.Text = "Pix:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(23, 118);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 17;
            label13.Text = "Dinheiro:";
            // 
            // txt_simulacao_dinheiro
            // 
            txt_simulacao_dinheiro.AutoSize = true;
            txt_simulacao_dinheiro.ForeColor = Color.Black;
            txt_simulacao_dinheiro.Location = new Point(84, 118);
            txt_simulacao_dinheiro.Name = "txt_simulacao_dinheiro";
            txt_simulacao_dinheiro.Size = new Size(0, 15);
            txt_simulacao_dinheiro.TabIndex = 26;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(23, 208);
            label19.Name = "label19";
            label19.Size = new Size(107, 15);
            label19.TabIndex = 27;
            label19.Text = "Cartão Crédito 3x:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(23, 190);
            label20.Name = "label20";
            label20.Size = new Size(107, 15);
            label20.TabIndex = 28;
            label20.Text = "Cartão Crédito 2x:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(23, 172);
            label21.Name = "label21";
            label21.Size = new Size(131, 15);
            label21.TabIndex = 29;
            label21.Text = "Cartão Crédito À Vista:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(23, 154);
            label22.Name = "label22";
            label22.Size = new Size(85, 15);
            label22.TabIndex = 30;
            label22.Text = "Cartão débito:";
            // 
            // bt_confirmar
            // 
            bt_confirmar.Location = new Point(160, 282);
            bt_confirmar.Name = "bt_confirmar";
            bt_confirmar.Size = new Size(75, 23);
            bt_confirmar.TabIndex = 31;
            bt_confirmar.Text = "Confirmar";
            bt_confirmar.UseVisualStyleBackColor = true;
            bt_confirmar.Click += bt_confirmar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(90, 118);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 33;
            // 
            // txt_simulacao_credito3x
            // 
            txt_simulacao_credito3x.AutoSize = true;
            txt_simulacao_credito3x.Location = new Point(136, 208);
            txt_simulacao_credito3x.Name = "txt_simulacao_credito3x";
            txt_simulacao_credito3x.Size = new Size(0, 15);
            txt_simulacao_credito3x.TabIndex = 34;
            // 
            // txt_simulacao_credito2x
            // 
            txt_simulacao_credito2x.AutoSize = true;
            txt_simulacao_credito2x.Location = new Point(136, 190);
            txt_simulacao_credito2x.Name = "txt_simulacao_credito2x";
            txt_simulacao_credito2x.Size = new Size(0, 15);
            txt_simulacao_credito2x.TabIndex = 35;
            // 
            // txt_simulacao_credito_avista
            // 
            txt_simulacao_credito_avista.AutoSize = true;
            txt_simulacao_credito_avista.Location = new Point(160, 172);
            txt_simulacao_credito_avista.Name = "txt_simulacao_credito_avista";
            txt_simulacao_credito_avista.Size = new Size(0, 15);
            txt_simulacao_credito_avista.TabIndex = 36;
            // 
            // txt_simulacao_debito
            // 
            txt_simulacao_debito.AutoSize = true;
            txt_simulacao_debito.Location = new Point(114, 154);
            txt_simulacao_debito.Name = "txt_simulacao_debito";
            txt_simulacao_debito.Size = new Size(0, 15);
            txt_simulacao_debito.TabIndex = 37;
            // 
            // txt_simulacao_pix
            // 
            txt_simulacao_pix.AutoSize = true;
            txt_simulacao_pix.Location = new Point(56, 136);
            txt_simulacao_pix.Name = "txt_simulacao_pix";
            txt_simulacao_pix.Size = new Size(0, 15);
            txt_simulacao_pix.TabIndex = 38;
            // 
            // cb_desconto
            // 
            cb_desconto.AutoSize = true;
            cb_desconto.Location = new Point(280, 132);
            cb_desconto.Name = "cb_desconto";
            cb_desconto.Size = new Size(15, 14);
            cb_desconto.TabIndex = 39;
            cb_desconto.UseVisualStyleBackColor = true;
            cb_desconto.CheckedChanged += cb_desconto_CheckedChanged;
            // 
            // txt_acrescimo
            // 
            txt_acrescimo.Enabled = false;
            txt_acrescimo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_acrescimo.ForeColor = Color.Black;
            txt_acrescimo.Location = new Point(301, 84);
            txt_acrescimo.Name = "txt_acrescimo";
            txt_acrescimo.Size = new Size(100, 23);
            txt_acrescimo.TabIndex = 41;
            txt_acrescimo.TextChanged += txt_acrescimo_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(301, 66);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 40;
            label18.Text = "Acréscimo";
            // 
            // txt_valorFinal
            // 
            txt_valorFinal.Enabled = false;
            txt_valorFinal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_valorFinal.ForeColor = Color.Black;
            txt_valorFinal.Location = new Point(301, 182);
            txt_valorFinal.Name = "txt_valorFinal";
            txt_valorFinal.Size = new Size(100, 23);
            txt_valorFinal.TabIndex = 45;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(301, 164);
            label23.Name = "label23";
            label23.Size = new Size(64, 15);
            label23.TabIndex = 44;
            label23.Text = "Valor total";
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 340);
            Controls.Add(txt_valorFinal);
            Controls.Add(label23);
            Controls.Add(txt_acrescimo);
            Controls.Add(label18);
            Controls.Add(cb_desconto);
            Controls.Add(txt_simulacao_pix);
            Controls.Add(txt_simulacao_debito);
            Controls.Add(txt_simulacao_credito_avista);
            Controls.Add(txt_simulacao_credito2x);
            Controls.Add(txt_simulacao_credito3x);
            Controls.Add(label11);
            Controls.Add(bt_confirmar);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(txt_simulacao_dinheiro);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(cb_pagamento);
            Controls.Add(label5);
            Controls.Add(txt_desconto);
            Controls.Add(label4);
            Controls.Add(txt_valor_total);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPayment";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagamento";
            Load += FrmPayment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private ComboBox cb_pagamento;
        private Label label6;
        private Label label12;
        private Label label13;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label txt_simulacao_dinheiro;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button bt_confirmar;
        private Label label11;
        private Label txt_simulacao_credito3x;
        private Label txt_simulacao_credito2x;
        private Label txt_simulacao_credito_avista;
        private Label txt_simulacao_debito;
        private Label txt_simulacao_pix;
        public Label label1;
        public TextBox txt_valor_total;
        public TextBox txt_desconto;
        public Label label4;
        private CheckBox cb_desconto;
        public TextBox txt_acrescimo;
        public Label label18;
        public TextBox txt_valorFinal;
        public Label label23;
    }
}