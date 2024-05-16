namespace TelaPIM
{
    partial class FrmProduction
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
            labelProduction = new Label();
            SuspendLayout();
            // 
            // labelProduction
            // 
            labelProduction.Location = new Point(145, 38);
            labelProduction.Name = "labelProduction";
            labelProduction.Size = new Size(196, 23);
            labelProduction.TabIndex = 1;
            labelProduction.Text = "Formulário Produção";
            labelProduction.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmProduction
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 509);
            Controls.Add(labelProduction);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProduction";
            Text = "FrmProduction";
            ResumeLayout(false);
        }

        #endregion

        private Label labelProduction;
    }
}