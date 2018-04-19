using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception_Real
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numirator;
            int denominator;
            int result;

            try
            { 
            numirator = Convert.ToInt32(txtNumirator.Text);
            denominator = Convert.ToInt32(txtDenomirator.Text);
           
           
                result = numirator / denominator;
            }

            catch(FormatException dataProblemException)
            {
                MessageBox.Show(dataProblemException.Message);
            }

            catch(DivideByZeroException divZeroException)
            {
                MessageBox.Show(divZeroException.Message);
            }

            //lblOut.Text = Convert.ToString(result);
        }
    }
}
