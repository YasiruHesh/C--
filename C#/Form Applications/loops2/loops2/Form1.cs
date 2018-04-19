using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int maxletters, currentPossition = 0;
            string sentence;
            char currentLetter, searchLetter;
            Boolean matchFound = false;
            const int substringLength = 1;

            sentence = txtInput.Text;
            searchLetter = Convert.ToChar(txtSearch.Text);
            maxletters = sentence.Length;
            do
            {
                currentLetter = Convert.ToChar(sentence.Substring(currentPossition, substringLength));
                currentPossition = currentPossition + 1;

                if (currentLetter == searchLetter)
                    matchFound = true;
            } while ((!matchFound) && (currentPossition < maxletters));

            if (matchFound)
                lblOut.Text = "Letter First Found at location" + Convert.ToString(currentPossition);
            else
                lblOut.Text = "Letter is not found you sone of a bitch";
        }
    }
}
