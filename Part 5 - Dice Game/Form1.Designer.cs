namespace Part_5___Dice_Game
{
    partial class Form1
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
            this.rtbDice = new System.Windows.Forms.RichTextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblBankAccountLabel = new System.Windows.Forms.Label();
            this.lblBetInstructions = new System.Windows.Forms.Label();
            this.rtbDice2 = new System.Windows.Forms.RichTextBox();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbDice
            // 
            this.rtbDice.Location = new System.Drawing.Point(12, 12);
            this.rtbDice.Name = "rtbDice";
            this.rtbDice.Size = new System.Drawing.Size(99, 109);
            this.rtbDice.TabIndex = 0;
            this.rtbDice.Text = "       ________ \n    /\\                \\\n  / O\\       O       \\\n/        \\_______" +
    "_ \\\n\\        /  O           /\n  \\ O/        O     /\n    \\/______O/";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(91, 172);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblBankAccountLabel
            // 
            this.lblBankAccountLabel.AutoSize = true;
            this.lblBankAccountLabel.Location = new System.Drawing.Point(288, 15);
            this.lblBankAccountLabel.Name = "lblBankAccountLabel";
            this.lblBankAccountLabel.Size = new System.Drawing.Size(78, 13);
            this.lblBankAccountLabel.TabIndex = 2;
            this.lblBankAccountLabel.Text = "Bank Account:";
            // 
            // lblBetInstructions
            // 
            this.lblBetInstructions.AutoSize = true;
            this.lblBetInstructions.Location = new System.Drawing.Point(12, 133);
            this.lblBetInstructions.Name = "lblBetInstructions";
            this.lblBetInstructions.Size = new System.Drawing.Size(81, 13);
            this.lblBetInstructions.TabIndex = 4;
            this.lblBetInstructions.Text = "Place Your Bet!";
            // 
            // rtbDice2
            // 
            this.rtbDice2.Location = new System.Drawing.Point(144, 12);
            this.rtbDice2.Name = "rtbDice2";
            this.rtbDice2.Size = new System.Drawing.Size(99, 109);
            this.rtbDice2.TabIndex = 5;
            this.rtbDice2.Text = "       ________ \n    /\\                \\\n  / O\\       O       \\\n/        \\_______" +
    "_ \\\n\\        /  O           /\n  \\ O/        O     /\n    \\/______O/\n";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(372, 15);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(25, 13);
            this.lblBankAccount.TabIndex = 6;
            this.lblBankAccount.Text = "100";
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(110, 130);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(133, 20);
            this.txtBetAmount.TabIndex = 7;
            this.txtBetAmount.Text = "Type Bet Here";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(284, 37);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(113, 158);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.AutoSize = true;
            this.lblDollarSign.Location = new System.Drawing.Point(362, 15);
            this.lblDollarSign.Name = "lblDollarSign";
            this.lblDollarSign.Size = new System.Drawing.Size(13, 13);
            this.lblDollarSign.TabIndex = 9;
            this.lblDollarSign.Text = "$";
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 153);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(228, 16);
            this.lblError.TabIndex = 10;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 210);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDollarSign);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.rtbDice2);
            this.Controls.Add(this.lblBetInstructions);
            this.Controls.Add(this.lblBankAccountLabel);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.rtbDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDice;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblBankAccountLabel;
        private System.Windows.Forms.Label lblBetInstructions;
        private System.Windows.Forms.RichTextBox rtbDice2;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblDollarSign;
        private System.Windows.Forms.Label lblError;
    }
}

