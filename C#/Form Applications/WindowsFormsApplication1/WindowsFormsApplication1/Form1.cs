using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdiCW.Checked = true;
            rdiUG.Checked = true;
        }
        

        private void rdiCW_CheckedChanged(object sender, EventArgs e)
        {
            getPersentage();
        }
        private void getPersentage()
        {
            int percentage;

            if(rdiCW.Checked)
            {
                if (rdiUG.Checked)
                    percentage = 30;
                else
                    percentage = 50;
            }
            else
            {
                if (rdiUG.Checked)
                    percentage = 40;
                else
                    percentage = 60;
            }
            lblOutPut.Text = Convert.ToString(percentage);

        }

        private void rdExam_CheckedChanged(object sender, EventArgs e)
        {
            getPersentage();
        }

        private void rdiUG_CheckedChanged(object sender, EventArgs e)
        {
            getPersentage();
        }

        private void rdiPG_CheckedChanged(object sender, EventArgs e)
        {
            getPersentage();
        }
    }
}
