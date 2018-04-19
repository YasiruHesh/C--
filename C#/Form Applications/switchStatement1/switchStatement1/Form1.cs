using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchStatement1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectClass_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(txtinput.Text);

            switch(age)
            {
                case 1:
                    lblout.Text = "chicks";
                    break;
                case 2:
                    lblout.Text = "Ducks";
                    break;
                case 3:
                    lblout.Text = "Signets";
                    break;
                case 4:
                    lblout.Text = "Swarns";
                    break;
                default:
                    lblout.Text = "You are Not Eligible";
                    break;
            }
        }
    }
}
