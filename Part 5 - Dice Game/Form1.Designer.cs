namespace Part_5___Dice_Game
{
    partial class DiceGame
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
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.grpBetChoice = new System.Windows.Forms.GroupBox();
            this.radDoubles = new System.Windows.Forms.RadioButton();
            this.radNotDoubles = new System.Windows.Forms.RadioButton();
            this.radOddSum = new System.Windows.Forms.RadioButton();
            this.radEvenSum = new System.Windows.Forms.RadioButton();
            this.grpBetChoice.SuspendLayout();
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
            this.btnRoll.BackColor = System.Drawing.Color.Black;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.ForeColor = System.Drawing.Color.White;
            this.btnRoll.Location = new System.Drawing.Point(86, 201);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblBankAccountLabel
            // 
            this.lblBankAccountLabel.AutoSize = true;
            this.lblBankAccountLabel.ForeColor = System.Drawing.Color.White;
            this.lblBankAccountLabel.Location = new System.Drawing.Point(249, 15);
            this.lblBankAccountLabel.Name = "lblBankAccountLabel";
            this.lblBankAccountLabel.Size = new System.Drawing.Size(78, 13);
            this.lblBankAccountLabel.TabIndex = 2;
            this.lblBankAccountLabel.Text = "Bank Account:";
            // 
            // lblBetInstructions
            // 
            this.lblBetInstructions.AutoSize = true;
            this.lblBetInstructions.ForeColor = System.Drawing.Color.White;
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
            this.lblBankAccount.ForeColor = System.Drawing.Color.White;
            this.lblBankAccount.Location = new System.Drawing.Point(342, 15);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(25, 13);
            this.lblBankAccount.TabIndex = 6;
            this.lblBankAccount.Text = "100";
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.BackColor = System.Drawing.Color.Black;
            this.txtBetAmount.ForeColor = System.Drawing.Color.White;
            this.txtBetAmount.Location = new System.Drawing.Point(110, 130);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(133, 20);
            this.txtBetAmount.TabIndex = 7;
            this.txtBetAmount.Text = "Type Bet Here";
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.AutoSize = true;
            this.lblDollarSign.ForeColor = System.Drawing.Color.White;
            this.lblDollarSign.Location = new System.Drawing.Point(323, 15);
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
            this.lblError.Size = new System.Drawing.Size(228, 42);
            this.lblError.TabIndex = 10;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBetChoice
            // 
            this.grpBetChoice.Controls.Add(this.radEvenSum);
            this.grpBetChoice.Controls.Add(this.radOddSum);
            this.grpBetChoice.Controls.Add(this.radNotDoubles);
            this.grpBetChoice.Controls.Add(this.radDoubles);
            this.grpBetChoice.Location = new System.Drawing.Point(252, 55);
            this.grpBetChoice.Name = "grpBetChoice";
            this.grpBetChoice.Size = new System.Drawing.Size(145, 140);
            this.grpBetChoice.TabIndex = 11;
            this.grpBetChoice.TabStop = false;
            this.grpBetChoice.Text = "Bet Choice";
            // 
            // radDoubles
            // 
            this.radDoubles.AutoSize = true;
            this.radDoubles.Location = new System.Drawing.Point(20, 32);
            this.radDoubles.Name = "radDoubles";
            this.radDoubles.Size = new System.Drawing.Size(64, 17);
            this.radDoubles.TabIndex = 0;
            this.radDoubles.TabStop = true;
            this.radDoubles.Text = "Doubles";
            this.radDoubles.UseVisualStyleBackColor = true;
            // 
            // radNotDoubles
            // 
            this.radNotDoubles.AutoSize = true;
            this.radNotDoubles.Location = new System.Drawing.Point(20, 56);
            this.radNotDoubles.Name = "radNotDoubles";
            this.radNotDoubles.Size = new System.Drawing.Size(84, 17);
            this.radNotDoubles.TabIndex = 1;
            this.radNotDoubles.TabStop = true;
            this.radNotDoubles.Text = "Not Doubles";
            this.radNotDoubles.UseVisualStyleBackColor = true;
            // 
            // radOddSum
            // 
            this.radOddSum.AutoSize = true;
            this.radOddSum.Location = new System.Drawing.Point(20, 78);
            this.radOddSum.Name = "radOddSum";
            this.radOddSum.Size = new System.Drawing.Size(66, 17);
            this.radOddSum.TabIndex = 2;
            this.radOddSum.TabStop = true;
            this.radOddSum.Text = "OddSum";
            this.radOddSum.UseVisualStyleBackColor = true;
            // 
            // radEvenSum
            // 
            this.radEvenSum.AutoSize = true;
            this.radEvenSum.Location = new System.Drawing.Point(20, 102);
            this.radEvenSum.Name = "radEvenSum";
            this.radEvenSum.Size = new System.Drawing.Size(74, 17);
            this.radEvenSum.TabIndex = 3;
            this.radEvenSum.TabStop = true;
            this.radEvenSum.Text = "Even Sum";
            this.radEvenSum.UseVisualStyleBackColor = true;
            // 
            // DiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(413, 236);
            this.Controls.Add(this.grpBetChoice);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDollarSign);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.rtbDice2);
            this.Controls.Add(this.lblBetInstructions);
            this.Controls.Add(this.lblBankAccountLabel);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.rtbDice);
            this.Name = "DiceGame";
            this.Text = "Part 5 - Dice Game";
            this.grpBetChoice.ResumeLayout(false);
            this.grpBetChoice.PerformLayout();
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
        private System.Windows.Forms.Label lblDollarSign;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox grpBetChoice;
        private System.Windows.Forms.RadioButton radEvenSum;
        private System.Windows.Forms.RadioButton radOddSum;
        private System.Windows.Forms.RadioButton radNotDoubles;
        private System.Windows.Forms.RadioButton radDoubles;
    }
}

