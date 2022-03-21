﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5___Dice_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Always gets doubles - Must fix
        Random generator1 = new Random();
        int die1;
        int die2;
        double betAmount;
        double bankAccount;
        double bankAccountRun;
        double newAccountTotal;
        double payReturn;
        private void btnRoll_Click(object sender, EventArgs e)
        {
            die1 = generator1.Next(1, 7);
            switch (die1)
            {
                case 1:
                    rtbDice.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |                    |\n" +
                    "  |          O       |\n" +
                    "  |                    |\n" +
                    "  |__________|");
                    break;
                case 2:
                    rtbDice.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |      O            |\n" +
                    "  |                    |\n" +
                    "  |            O     |\n" +
                    "  |__________|");
                    break;
                case 3:
                    rtbDice.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |     O            |\n" +
                    "  |         O        |\n" +
                    "  |             O    |\n" +
                    "  |__________|");
                    break;
                case 4:
                    rtbDice.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
                case 5:
                    rtbDice.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |        O         |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
                default:
                    rtbDice.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |   O       O    |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
            }

            die2 = generator1.Next(1, 7);
            switch (die2)
            {
                case 1:
                    rtbDice2.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |                    |\n" +
                    "  |          O       |\n" +
                    "  |                    |\n" +
                    "  |__________|");
                    break;
                case 2:
                    rtbDice2.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |      O            |\n" +
                    "  |                    |\n" +
                    "  |            O     |\n" +
                    "  |__________|");
                    break;
                case 3:
                    rtbDice2.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |     O            |\n" +
                    "  |         O        |\n" +
                    "  |             O    |\n" +
                    "  |__________|");
                    break;
                case 4:
                    rtbDice2.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
                case 5:
                    rtbDice2.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |        O         |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
                default:
                    rtbDice2.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |   O       O    |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
            }
            //Gambling If Statements
                if (betAmount <= bankAccount)
                {
                    lblError.Text = ("");
                    if (double.TryParse(txtBetAmount.Text, out betAmount))
                    {
                        if (double.TryParse(lblBankAccount.Text, out bankAccount))
                        {
                            bankAccountRun = bankAccount - betAmount;
                            lblBankAccount.Text = Convert.ToString(bankAccountRun);
                        }

                        if (die1 == die2)
                        {
                            payReturn = betAmount * 2;
                            newAccountTotal = payReturn + bankAccountRun;
                            lblBankAccount.Text = Convert.ToString(newAccountTotal);
                        }
                        else if (die1 != die2)
                        {
                            payReturn = betAmount * 1.5;
                            newAccountTotal = payReturn + bankAccountRun;
                            lblBankAccount.Text = Convert.ToString(newAccountTotal);
                        }
                    }

                }
                else
                {
                    lblError.Text = ("Error! Insufficient Funds!");
                }
        }
    } 
}
