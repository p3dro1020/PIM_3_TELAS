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
            txt_valor_pago = new TextBox();
            label2 = new Label();
            txt_resto = new TextBox();
            label3 = new Label();
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
            bt_imprimir = new Button();
            label11 = new Label();
            txt_simulacao_credito3x = new Label();
            txt_simulacao_credito2x = new Label();
            txt_simulacao_credito_avista = new Label();
            txt_simulacao_debito = new Label();
            txt_simulacao_pix = new Label();
            cb_desconto = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(346, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor total";
            // 
            // txt_valor_total
            // 
            txt_valor_total.Enabled = false;
            txt_valor_total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_valor_total.ForeColor = Color.Black;
            txt_valor_total.Location = new Point(346, 37);
            txt_valor_total.Name = "txt_valor_total";
            txt_valor_total.Size = new Size(100, 23);
            txt_valor_total.TabIndex = 1;
            // 
            // txt_valor_pago
            // 
            txt_valor_pago.ForeColor = Color.Black;
            txt_valor_pago.Location = new Point(346, 147);
            txt_valor_pago.Name = "txt_valor_pago";
            txt_valor_pago.Size = new Size(100, 23);
            txt_valor_pago.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(346, 129);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor pago";
            // 
            // txt_resto
            // 
            txt_resto.Enabled = false;
            txt_resto.ForeColor = Color.Black;
            txt_resto.Location = new Point(346, 205);
            txt_resto.Name = "txt_resto";
            txt_resto.Size = new Size(100, 23);
            txt_resto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(346, 187);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Restante";
            // 
            // txt_desconto
            // 
            txt_desconto.Enabled = false;
            txt_desconto.ForeColor = Color.Black;
            txt_desconto.Location = new Point(346, 92);
            txt_desconto.Name = "txt_desconto";
            txt_desconto.Size = new Size(100, 23);
            txt_desconto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(346, 74);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Desconto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 19);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
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
            bt_confirmar.Location = new Point(123, 289);
            bt_confirmar.Name = "bt_confirmar";
            bt_confirmar.Size = new Size(75, 23);
            bt_confirmar.TabIndex = 31;
            bt_confirmar.Text = "Confirmar";
            bt_confirmar.UseVisualStyleBackColor = true;
            bt_confirmar.Click += bt_confirmar_Click;
            // 
            // bt_imprimir
            // 
            bt_imprimir.Location = new Point(221, 289);
            bt_imprimir.Name = "bt_imprimir";
            bt_imprimir.Size = new Size(75, 23);
            bt_imprimir.TabIndex = 32;
            bt_imprimir.Text = "Imprimir";
            bt_imprimir.UseVisualStyleBackColor = true;
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
            cb_desconto.Location = new Point(325, 96);
            cb_desconto.Name = "cb_desconto";
            cb_desconto.Size = new Size(15, 14);
            cb_desconto.TabIndex = 39;
            cb_desconto.UseVisualStyleBackColor = true;
            cb_desconto.CheckedChanged += cb_desconto_CheckedChanged;
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(473, 335);
            Controls.Add(cb_desconto);
            Controls.Add(txt_simulacao_pix);
            Controls.Add(txt_simulacao_debito);
            Controls.Add(txt_simulacao_credito_avista);
            Controls.Add(txt_simulacao_credito2x);
            Controls.Add(txt_simulacao_credito3x);
            Controls.Add(label11);
            Controls.Add(bt_imprimir);
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
            Controls.Add(txt_resto);
            Controls.Add(label3);
            Controls.Add(txt_valor_pago);
            Controls.Add(label2);
            Controls.Add(txt_valor_total);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPayment";
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
        private Button bt_imprimir;
        private Label label11;
        private Label txt_simulacao_credito3x;
        private Label txt_simulacao_credito2x;
        private Label txt_simulacao_credito_avista;
        private Label txt_simulacao_debito;
        private Label txt_simulacao_pix;
        public Label label1;
        public TextBox txt_valor_total;
        public TextBox txt_valor_pago;
        public Label label2;
        public TextBox txt_resto;
        public Label label3;
        public TextBox txt_desconto;
        public Label label4;
        private CheckBox cb_desconto;
    }
}