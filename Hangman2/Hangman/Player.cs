using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Hangman
{
    public partial class Player : Form
    {
        char[] word = Facilitator.changeWord;
        Label[] labels = new Label[10];
        int flag;
        int wrongs = 0;

        public Player()
        {
            InitializeComponent();
            labels = new Label[] {label1, label2, label3, label4, label5, label6, label7, label8, label9, label10};
            remove();
        }

        void remove()
        {
            int wordLength = word.Length;
            for (int i = wordLength; i < labels.Length; i++) 
            {
                labels[i].Text = "";
            }
        }

        void check()
        {
            int done = 1;
            for (int i = 0;  i < labels.Length; i++)
            {
                if (labels[i].Text == "*")
                    done = 0;
            }

            if (done == 1)
            {
                MessageBox.Show("Congratulations! You guessed the word correctly!", "You Won!");
            }
        }

        void wrong()
        {
            wrongs += 1;
            listBox1.Items.Add("WRONG " + wrongs);

            if (wrongs > 6)
            {
                MessageBox.Show("Game Over! Man has been Hanged");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'A')
                {
                    labels[i].Text = "A";
                    button1.Visible = false;
                    flag = 1;
                }           
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'B')
                {
                    labels[i].Text = "B";
                    button2.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'C')
                {
                    labels[i].Text = "C";
                    button3.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'D')
                {
                    labels[i].Text = "D";
                    button4.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'E')
                {
                    labels[i].Text = "E";
                    button5.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'F')
                {
                    labels[i].Text = "F";
                    button6.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'G')
                {
                    labels[i].Text = "G";
                    button7.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'H')
                {
                    labels[i].Text = "H";
                    button8.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'I')
                {
                    labels[i].Text = "I";
                    button9.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'J')
                {
                    labels[i].Text = "J";
                    button10.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'K')
                {
                    labels[i].Text = "K";
                    button11.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'L')
                {
                    labels[i].Text = "L";
                    button12.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'M')
                {
                    labels[i].Text = "M";
                    button13.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'N')
                {
                    labels[i].Text = "N";
                    button14.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'O')
                {
                    labels[i].Text = "O";
                    button15.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'P')
                {
                    labels[i].Text = "P";
                    button16.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'Q')
                {
                    labels[i].Text = "Q";
                    button17.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'R')
                {
                    labels[i].Text = "R";
                    button18.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'S')
                {
                    labels[i].Text = "S";
                    button19.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'T')
                {
                    labels[i].Text = "T";
                    button20.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'U')
                {
                    labels[i].Text = "U";
                    button21.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'V')
                {
                    labels[i].Text = "V";
                    button22.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'W')
                {
                    labels[i].Text = "W";
                    button23.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'X')
                {
                    labels[i].Text = "X";
                    button24.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'Y')
                {
                    labels[i].Text = "Y";
                    button25.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'Z')
                {
                    labels[i].Text = "Z";
                    button26.Visible = false;
                    flag = 1;
                }
            }

            if (flag == 0)
                wrong();

            check();
        }
    }
}
