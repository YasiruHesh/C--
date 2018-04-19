using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_lottry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Random get_number = new Random();
            int num1, num2;

            num1 = get_number.Next(1, 49);

            do
            {
                num2 = get_number.Next(1, 49);

            } while (num1 == num2);
            lblOut.Text = "this week numbers are" +Convert.ToString(num1) +"and"  +Convert.ToString(num2);
        }

        
    }
}
