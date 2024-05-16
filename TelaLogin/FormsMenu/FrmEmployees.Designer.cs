namespace TelaPIM
{
    partial class FrmEmployees
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
            labelEmplyees = new Label();
            SuspendLayout();
            // 
            // labelEmplyees
            // 
            labelEmplyees.Location = new Point(187, 39);
            labelEmplyees.Name = "labelEmplyees";
            labelEmplyees.Size = new Size(176, 23);
            labelEmplyees.TabIndex = 1;
            labelEmplyees.Text = "Formulário funcionários";
            labelEmplyees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 509);
            Controls.Add(labelEmplyees);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployees";
            Text = "FrmEmployees";
            ResumeLayout(false);
        }

        #endregion

        private Label labelEmplyees;
    }
}