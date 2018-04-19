using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i;
            string[] names;
            names = new string[4];

            for(i=0;i<4;i++)
            
                names[i] = "unset";

            lstOut.Items.Clear();
            for (i = 0; i < 4; i++) ;
                lstOut.Items.Add(names[1]);

            names[0] = "Bob";
            names[1] = "Jim";
            names[2] = "smith";
            names[3] = "jhon";

            for (i = 0; i < 4; i++) ;
            lstOut.Items.Add(names[i]); 
        }
    }
}
