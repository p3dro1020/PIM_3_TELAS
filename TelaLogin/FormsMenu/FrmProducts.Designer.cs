namespace TelaPIM
{
    partial class FrmProducts
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
            labelProducts = new Label();
            SuspendLayout();
            // 
            // labelProducts
            // 
            labelProducts.Location = new Point(142, 32);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(196, 23);
            labelProducts.TabIndex = 1;
            labelProducts.Text = "Formulário Produtos";
            labelProducts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 509);
            Controls.Add(labelProducts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            Text = "FrmProducts";
            ResumeLayout(false);
        }

        #endregion

        private Label labelProducts;
    }
}