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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);


                var firstLength = new Length(firstValue, MeasureType.C);
                var secondLength = new Length(secondValue, MeasureType.C);


                var sumLength = firstLength + secondLength;

                
                txtResult.Text = sumLength.Verbose();
            }
            catch (FormatException)
            {
                
            }
        }
    }
}
