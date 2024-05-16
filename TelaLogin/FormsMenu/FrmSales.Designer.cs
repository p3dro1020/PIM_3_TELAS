namespace TelaPIM
{
    partial class FrmSales
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
            labelSales = new Label();
            SuspendLayout();
            // 
            // labelSales
            // 
            labelSales.Location = new Point(152, 38);
            labelSales.Name = "labelSales";
            labelSales.Size = new Size(196, 23);
            labelSales.TabIndex = 1;
            labelSales.Text = "Formulário Vendas";
            labelSales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmSales
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 509);
            Controls.Add(labelSales);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSales";
            Text = "FrmSales";
            ResumeLayout(false);
        }

        #endregion

        private Label labelSales;
    }
}