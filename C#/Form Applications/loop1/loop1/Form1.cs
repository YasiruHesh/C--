using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            lstOutput.Items.Add("The umbers are:");
            
            int newNumber, i, total = 0;

            Random random = new Random();

            for(i=0;i<4;i++)
            {
                newNumber = random.Next(1, 100);
                lstOutput.Items.Add(Convert.ToString(newNumber));
                total = total + newNumber;

            }
            lstOutput.Items.Add(string.Format("The total is:{0}", total));
            lstOutput.Items.Add(string.Format("the average is {0:f}", total / 4f));

        }
    }
}
