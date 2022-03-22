using System;
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
    public partial class DiceGame : Form
    {
        public DiceGame()
        {
            InitializeComponent();
        }
        Random generator1 = new Random();
        int die1;
        int die2;
        double betAmount;
        double bankAccount;
        double bankAccountRun;
        double payReturn;
        
        private void btnRoll_Click(object sender, EventArgs e)
        {
            bankAccount = double.Parse(lblBankAccount.Text);
            
            if (double.TryParse(txtBetAmount.Text, out betAmount))
            {
                die1 = generator1.Next(1, 7);
                DrawDie(die1, rtbDice);
                

                die2 = generator1.Next(1, 7);
                DrawDie(die2, rtbDice2);
                

                if (betAmount <= bankAccount && betAmount > 0)
                {
                    bankAccountRun = bankAccount - betAmount;
                    if (die1 == die2)
                    {
                        payReturn = betAmount * 2;
                        bankAccount = (bankAccountRun + payReturn);
                        lblBankAccount.Text = bankAccount + "";
                    }
                    else if (die1 != die2)
                    {
                        payReturn = betAmount * 1.5;
                        bankAccount = (bankAccountRun + payReturn);
                        lblBankAccount.Text = bankAccount + "";
                    }
                    lblError.Text = ("");
                }
                else
                {
                    lblError.Text = ($"Please enter a valid bet amount. (Between $0 and ${bankAccount}");
                }
            }
            else
            {
                lblError.Text = ($"Please enter a valid numerical bet amount. (Between $0 and ${bankAccount}");
            }
            
        }






        private void DrawDie(int roll, RichTextBox textBox)
        {
            switch (roll)
            {
                case 1:
                    textBox.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |                    |\n" +
                    "  |          O       |\n" +
                    "  |                    |\n" +
                    "  |__________|");
                    break;
                case 2:
                    textBox.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |      O            |\n" +
                    "  |                    |\n" +
                    "  |            O     |\n" +
                    "  |__________|");
                    break;
                case 3:
                    textBox.Text = ("  __________\n" +
                    "  |                    |\n" +
                    "  |     O            |\n" +
                    "  |         O        |\n" +
                    "  |             O    |\n" +
                    "  |__________|");
                    break;
                case 4:
                    textBox.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
                case 5:
                    textBox.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |        O         |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
                default:
                    textBox.Text = ("  __________\n" +
                    "  |                   |\n" +
                    "  |   O       O    |\n" +
                    "  |   O       O    |\n" +
                    "  |   O       O    |\n" +
                    "  |__________|");
                    break;
            }
        }


        private void lblBankAccount_Click(object sender, EventArgs e)
        {

        }
    } 
}
