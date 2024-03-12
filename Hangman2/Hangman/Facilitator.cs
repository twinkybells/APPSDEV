using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Facilitator : Form
    {
        string newWord;
        char[] concealed;
        public static char[] changeWord;
        public Facilitator()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            newWord = txtChange.Text;
            newWord = newWord.ToUpper();
            lblCurrent.Text = newWord;
            changeWord = newWord.ToCharArray();
        }
    }
}
