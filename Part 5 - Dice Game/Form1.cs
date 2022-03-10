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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Always gets doubles - Must fix
        Random generator1 = new Random();
        Random generator2 = new Random();
        int die1;
        int die2;
        private void btnRoll_Click(object sender, EventArgs e)
        {
            die1 = generator1.Next(1, 7);
            die2 = generator2.Next(1, 7);
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
        }
    }
}
