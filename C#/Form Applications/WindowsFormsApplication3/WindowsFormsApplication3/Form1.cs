using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int maxLetter, currentPossitiin = 0;
            string sentence;
            char currentLetter, searchLetter;
            Boolean matchFound = false;
            const int substringLength = 0;

            searchLetter = Convert.ToChar(txtLetter.Text);
            sentence = txtSentence.Text;
            maxLetter = sentence.Length;

            do
            {
                currentLetter = Convert.ToChar(sentence.Substring(currentPossitiin, substringLength));
                currentPossitiin = currentPossitiin + 1;

                if (currentLetter == searchLetter)
                    matchFound = true;



            } while ((!matchFound) && (currentLetter < maxLetter));
            if (matchFound)
                lblOut.Text = "the letter found" + Convert.ToString(currentPossitiin);
            else
                lblOut.Text = "the letter not found";
        }   
    }
}
