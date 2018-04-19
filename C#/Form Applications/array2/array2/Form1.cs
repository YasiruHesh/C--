using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,j;
            int[,] matrix;
            matrix = new int[3, 3];
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++) ;
            matrix[i, j] = (i + 1) * (j + 1);

            lstOut.Items.Add(matrix[i, j]);
        }
    }
}
