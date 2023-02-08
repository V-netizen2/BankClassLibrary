namespace DemoForm
{
    partial class CreateAccountForm
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
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.PhoneCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressCheckBox = new System.Windows.Forms.CheckBox();
            this.customTextBoxControl1 = new DemoForm.CustomTextBoxControl();
            this.SuspendLayout();
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(148, 27);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(24, 27);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(94, 15);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(148, 70);
            this.BirthDatePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(200, 23);
            this.BirthDatePicker.TabIndex = 2;
            this.BirthDatePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(24, 70);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(55, 15);
            this.BirthDateLabel.TabIndex = 3;
            this.BirthDateLabel.Text = "Birthdate";
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(148, 115);
            this.PhoneMaskedTextBox.Mask = "(999)-000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.PhoneMaskedTextBox.TabIndex = 4;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(24, 115);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 15);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone";
            // 
            // AddressRichTextBox
            // 
            this.AddressRichTextBox.Location = new System.Drawing.Point(148, 160);
            this.AddressRichTextBox.Name = "AddressRichTextBox";
            this.AddressRichTextBox.Size = new System.Drawing.Size(200, 96);
            this.AddressRichTextBox.TabIndex = 6;
            this.AddressRichTextBox.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(24, 160);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 15);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Address";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(221, 270);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(75, 23);
            this.CreateAccountButton.TabIndex = 8;
            this.CreateAccountButton.Text = "Create";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // PhoneCheckBox
            // 
            this.PhoneCheckBox.AutoSize = true;
            this.PhoneCheckBox.Checked = true;
            this.PhoneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PhoneCheckBox.Location = new System.Drawing.Point(387, 119);
            this.PhoneCheckBox.Name = "PhoneCheckBox";
            this.PhoneCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PhoneCheckBox.TabIndex = 9;
            this.PhoneCheckBox.UseVisualStyleBackColor = true;
            this.PhoneCheckBox.CheckedChanged += new System.EventHandler(this.PhoneCheckBox_CheckedChanged);
            // 
            // AddressCheckBox
            // 
            this.AddressCheckBox.AutoSize = true;
            this.AddressCheckBox.Checked = true;
            this.AddressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddressCheckBox.Location = new System.Drawing.Point(387, 162);
            this.AddressCheckBox.Name = "AddressCheckBox";
            this.AddressCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AddressCheckBox.TabIndex = 10;
            this.AddressCheckBox.UseVisualStyleBackColor = true;
            this.AddressCheckBox.CheckedChanged += new System.EventHandler(this.AddressCheckBox_CheckedChanged);
            // 
            // customTextBoxControl1
            // 
            this.customTextBoxControl1.Location = new System.Drawing.Point(404, 27);
            this.customTextBoxControl1.Name = "customTextBoxControl1";
            this.customTextBoxControl1.Size = new System.Drawing.Size(349, 68);
            this.customTextBoxControl1.TabIndex = 11;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 323);
            this.Controls.Add(this.customTextBoxControl1);
            this.Controls.Add(this.AddressCheckBox);
            this.Controls.Add(this.PhoneCheckBox);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressRichTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account Panel";
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CustomerNameTextBox;
        private Label CustomerNameLabel;
        private DateTimePicker BirthDatePicker;
        private Label BirthDateLabel;
        private MaskedTextBox PhoneMaskedTextBox;
        private Label PhoneLabel;
        private RichTextBox AddressRichTextBox;
        private Label AddressLabel;
        private Button CreateAccountButton;
        private CheckBox PhoneCheckBox;
        private CheckBox AddressCheckBox;
        private CustomTextBoxControl customTextBoxControl1;
    }
}