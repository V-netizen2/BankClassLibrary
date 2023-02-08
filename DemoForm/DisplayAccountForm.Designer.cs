namespace DemoForm
{
    partial class DisplayAccountForm
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
            this.TransactionListBox = new System.Windows.Forms.ListBox();
            this.CustomerNamePanel = new DemoForm.CustomTextBoxControl();
            this.TransactionTypePanel = new DemoForm.CustomTextBoxControl();
            this.TransactionAmountPanel = new DemoForm.CustomTextBoxControl();
            this.TransactionDatePanel = new DemoForm.CustomTextBoxControl();
            this.TransactionLocationPanel = new DemoForm.CustomTextBoxControl();
            this.DepositAmountTextBox = new System.Windows.Forms.TextBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawAmountTextBox = new System.Windows.Forms.TextBox();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.BalanceControlPanel = new DemoForm.CustomTextBoxControl();
            this.SuspendLayout();
            // 
            // TransactionListBox
            // 
            this.TransactionListBox.FormattingEnabled = true;
            this.TransactionListBox.ItemHeight = 15;
            this.TransactionListBox.Items.AddRange(new object[] {
            "Transaction 1",
            "Transaction 2"});
            this.TransactionListBox.Location = new System.Drawing.Point(38, 36);
            this.TransactionListBox.Name = "TransactionListBox";
            this.TransactionListBox.Size = new System.Drawing.Size(180, 184);
            this.TransactionListBox.TabIndex = 0;
            this.TransactionListBox.SelectedIndexChanged += new System.EventHandler(this.TransactionListBox_SelectedIndexChanged);
            // 
            // CustomerNamePanel
            // 
            this.CustomerNamePanel.LabelText = "Customer Name";
            this.CustomerNamePanel.Location = new System.Drawing.Point(239, -9);
            this.CustomerNamePanel.Name = "CustomerNamePanel";
            this.CustomerNamePanel.Size = new System.Drawing.Size(377, 56);
            this.CustomerNamePanel.TabIndex = 1;
            this.CustomerNamePanel.TextInput = "jack";
            // 
            // TransactionTypePanel
            // 
            this.TransactionTypePanel.LabelText = "Transaction Type";
            this.TransactionTypePanel.Location = new System.Drawing.Point(251, 85);
            this.TransactionTypePanel.Name = "TransactionTypePanel";
            this.TransactionTypePanel.Size = new System.Drawing.Size(353, 64);
            this.TransactionTypePanel.TabIndex = 2;
            this.TransactionTypePanel.TextInput = "";
            // 
            // TransactionAmountPanel
            // 
            this.TransactionAmountPanel.LabelText = "Transaction Amount";
            this.TransactionAmountPanel.Location = new System.Drawing.Point(251, 146);
            this.TransactionAmountPanel.Name = "TransactionAmountPanel";
            this.TransactionAmountPanel.Size = new System.Drawing.Size(353, 49);
            this.TransactionAmountPanel.TabIndex = 3;
            this.TransactionAmountPanel.TextInput = "";
            // 
            // TransactionDatePanel
            // 
            this.TransactionDatePanel.LabelText = "Transaction Date";
            this.TransactionDatePanel.Location = new System.Drawing.Point(251, 201);
            this.TransactionDatePanel.Name = "TransactionDatePanel";
            this.TransactionDatePanel.Size = new System.Drawing.Size(377, 53);
            this.TransactionDatePanel.TabIndex = 4;
            this.TransactionDatePanel.TextInput = "";
            this.TransactionDatePanel.Load += new System.EventHandler(this.TransactionDatePanel_Load);
            // 
            // TransactionLocationPanel
            // 
            this.TransactionLocationPanel.LabelText = "Location";
            this.TransactionLocationPanel.Location = new System.Drawing.Point(263, 260);
            this.TransactionLocationPanel.Name = "TransactionLocationPanel";
            this.TransactionLocationPanel.Size = new System.Drawing.Size(353, 51);
            this.TransactionLocationPanel.TabIndex = 5;
            this.TransactionLocationPanel.TextInput = "";
            // 
            // DepositAmountTextBox
            // 
            this.DepositAmountTextBox.Location = new System.Drawing.Point(41, 242);
            this.DepositAmountTextBox.Name = "DepositAmountTextBox";
            this.DepositAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.DepositAmountTextBox.TabIndex = 6;
            this.DepositAmountTextBox.Text = "1000";
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(66, 271);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 23);
            this.DepositButton.TabIndex = 7;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawAmountTextBox
            // 
            this.WithdrawAmountTextBox.Location = new System.Drawing.Point(164, 242);
            this.WithdrawAmountTextBox.Name = "WithdrawAmountTextBox";
            this.WithdrawAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.WithdrawAmountTextBox.TabIndex = 8;
            this.WithdrawAmountTextBox.Text = "500";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(164, 274);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(75, 23);
            this.WithdrawButton.TabIndex = 9;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // BalanceControlPanel
            // 
            this.BalanceControlPanel.LabelText = "Current Balance";
            this.BalanceControlPanel.Location = new System.Drawing.Point(239, 53);
            this.BalanceControlPanel.Name = "BalanceControlPanel";
            this.BalanceControlPanel.Size = new System.Drawing.Size(377, 48);
            this.BalanceControlPanel.TabIndex = 10;
            this.BalanceControlPanel.TextInput = "";
            // 
            // DisplayAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 313);
            this.Controls.Add(this.BalanceControlPanel);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.WithdrawAmountTextBox);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.DepositAmountTextBox);
            this.Controls.Add(this.TransactionLocationPanel);
            this.Controls.Add(this.TransactionDatePanel);
            this.Controls.Add(this.TransactionAmountPanel);
            this.Controls.Add(this.TransactionTypePanel);
            this.Controls.Add(this.CustomerNamePanel);
            this.Controls.Add(this.TransactionListBox);
            this.Name = "DisplayAccountForm";
            this.Text = "Account Information";
            this.Load += new System.EventHandler(this.DisplayAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox TransactionListBox;
        private CustomTextBoxControl CustomerNamePanel;
        private CustomTextBoxControl TransactionTypePanel;
        private CustomTextBoxControl TransactionAmountPanel;
        private CustomTextBoxControl TransactionDatePanel;
        private CustomTextBoxControl TransactionLocationPanel;
        private TextBox DepositAmountTextBox;
        private Button DepositButton;
        private TextBox WithdrawAmountTextBox;
        private Button WithdrawButton;
        private CustomTextBoxControl BalanceControlPanel;
    }
}