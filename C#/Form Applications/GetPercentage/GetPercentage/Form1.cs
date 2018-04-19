using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPercentage
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void CW_CheckedChanged(object sender, EventArgs e)
        {
            GetPercentage();
        }
        private void GetPercentage()
        {
            int percentage;
            if (CW.Checked == true)
            {
                if (Ud.Checked == true)
                    percentage = 30;
                else
                    percentage = 50;
            }
            else
            {
                if (Ud.Checked == true)
                    percentage = 40;
                else
                    percentage = 60;
            }
            outPut.Text = Convert.ToString(percentage);
        }
    }
    }

