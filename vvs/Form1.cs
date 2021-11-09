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
            var measureItems = new string[]
       {
            "градус Цельсия",
            "градус Фаренгейта",
            "градус Ранкина",
            "Кельвинов",
       };

           
            cmbFirstType.DataSource = new List<string>(measureItems);
            cmbSecondType.DataSource = new List<string>(measureItems);
            cmbResultType.DataSource = new List<string>(measureItems);
        }
        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "градус Цельсия":
                    measureType = MeasureType.C;
                    break;
                case "градус Фаренгейта":
                    measureType = MeasureType.F;
                    break;
                case "градус Ранкина":
                    measureType = MeasureType.Ra;
                    break;
                case "Кельвинов":
                    measureType = MeasureType.K;
                    break;
                default:
                    measureType = MeasureType.C;
                    break;
            }
            return measureType;
        }
        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);
                var kfValue = double.Parse(txtKf.Text);
                MeasureType firstType = GetMeasureType(cmbFirstType);
                MeasureType secondType = GetMeasureType(cmbSecondType);
                MeasureType resultType = GetMeasureType(cmbResultType);
                var firstLength = new Length(firstValue, firstType);
                var secondLength = new Length(secondValue, secondType);
                var kfLength1 = new Length(firstValue, firstType);
                var kfLength2= new Length(secondValue, secondType);
                Length sumLength;
             

                switch (cmbOperation.Text)
                {
                    case "+":
                        
                        sumLength = firstLength + secondLength;
                        kfLength1 = kfValue * kfLength1;
                        kfLength2 = kfValue * kfLength2;
                        break;
                    case "-":
                      
                        sumLength = firstLength - secondLength;
                        kfLength1 = kfValue * kfLength1;
                        kfLength2 = kfValue * kfLength2;
                        break;
                   
                    default:
                        
                        sumLength = new Length(0, MeasureType.C);
                        break;
                }


                txtResult.Text = sumLength.To(resultType).Verbose();
                txtKfFirst.Text = kfLength1.To(firstType).Verbose();
                txtKfSecond.Text = kfLength2.To(secondType).Verbose();
            }
            catch (FormatException)
            {
            
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.txtFirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            Calculate();

            txtFirst.BackColor = Color.White;
            txtSecond.BackColor = Color.White;
            if (txtFirst.Text != "" && txtSecond.Text != "")
            {
                if (Int32.Parse(txtFirst.Text) > Int32.Parse(txtSecond.Text))
                    txtFirst.BackColor = Color.Coral;
                txtSecond.BackColor = Color.White;
            }
      
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            this.txtKfSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            Calculate();
            txtFirst.BackColor = Color.White;
            txtSecond.BackColor = Color.White;
            
            if (txtFirst.Text != "" && txtSecond.Text != "")
            {
                if (Int32.Parse(txtFirst.Text) < Int32.Parse(txtSecond.Text))
                    txtSecond.BackColor = Color.Coral;
                txtFirst.BackColor = Color.White;
            }
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbFirstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbSecondType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbResultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtKfFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
