using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swith2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numGoods;
            float costOriginal, costDiscounted, discountPercent, discountValue;

            numGoods = Convert.ToInt32(txtQuantity.Text);
            costOriginal = Convert.ToSingle(txtTotalCost.Text);

            discountPercent = getDiscount(numGoods);

            discountValue = costOriginal - discountPercent / 100;

            costDiscounted = costOriginal - discountValue;

            lblPercentage.Text = string.Format("{0}%", discountPercent);
            lblAmount.Text = string.Format("{0}", discountValue);
            lblBalance.Text = string.Format("{0}", costDiscounted);
            
        }
        private int getDiscount(int number)
        {
            
            int discount;

            switch(number)
            {
                case 2:
                    discount = 3;
                    break;
                case 3:
                    discount = 5;
                    break;
                case 4:
                    discount = 10;
                    break;
                case 5:
                    discount = 10;
                    break;
                default:
                    discount = 0;
                    break;                   
            }
            return discount;
        }
    }
}
