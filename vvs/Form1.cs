using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vvs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                var firstLength = new Length(firstValue, MeasureType.C);
                var secondLength = new Length(secondValue, MeasureType.C);
                Length sumLength;
                switch (cmbOperation.Text)
                {
                    case "+":
                        
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                      
                        sumLength = firstLength - secondLength;
                        break;
                    default:
                        
                        sumLength = new Length(0, MeasureType.C);
                        break;
                }
                

                txtResult.Text = sumLength.Verbose();
            }
            catch (FormatException)
            {
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
