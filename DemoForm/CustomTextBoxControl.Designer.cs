namespace DemoForm
{
    partial class CustomTextBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomTextBox = new System.Windows.Forms.TextBox();
            this.CustomLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CustomTextBox);
            this.panel1.Controls.Add(this.CustomLabel);
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 68);
            this.panel1.TabIndex = 4;
            // 
            // CustomTextBox
            // 
            this.CustomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomTextBox.Location = new System.Drawing.Point(128, 19);
            this.CustomTextBox.Name = "CustomTextBox";
            this.CustomTextBox.Size = new System.Drawing.Size(100, 23);
            this.CustomTextBox.TabIndex = 1;
            // 
            // CustomLabel
            // 
            this.CustomLabel.AutoSize = true;
            this.CustomLabel.Location = new System.Drawing.Point(24, 26);
            this.CustomLabel.Name = "CustomLabel";
            this.CustomLabel.Size = new System.Drawing.Size(38, 15);
            this.CustomLabel.TabIndex = 2;
            this.CustomLabel.Text = "label1";
            // 
            // CustomTextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomTextBoxControl";
            this.Size = new System.Drawing.Size(377, 81);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox CustomTextBox;
        private Label CustomLabel;
    }
}
