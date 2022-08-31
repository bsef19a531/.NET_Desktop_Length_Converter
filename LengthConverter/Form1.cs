using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthConverter
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LenghtTextBox.Text == "")
            {
                resultTextBox.Text = "";
                MessageBox.Show("The Input Box is Empty");
            }
            else if (countInstances(LenghtTextBox.Text, '.') > 1)
            {
                resultTextBox.Text = "";
                MessageBox.Show("The Input is Invalid, \n Enter a Decimal value");
            }
            else
            {

                if (inchesCheckBox.Checked == true)
                {
                    LengthFeet feets = new LengthFeet();
                    double val = Convert.ToDouble(LenghtTextBox.Text);
                    feets.setMeasurement(val);
                    resultTextBox.Text = Convert.ToString((feets.InchesToFeet())) + " feets";

                }
                else
                {
                    LengthInches inches = new LengthInches();
                    double val = Convert.ToDouble(LenghtTextBox.Text);
                    inches.setMeasurement(val);
                    resultTextBox.Text = Convert.ToString((inches.FeetToInches())) + " inches";
                }
            }

            }
            
           
        

        private void txtBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(inchesCheckBox.Checked == false)
            {
                feetCheckBox.Checked = true;
            }
            if(inchesCheckBox.Checked == true)
            {
                feetCheckBox.Checked = false;
            }
        }

        private void onFocusTextBox(object sender, EventArgs e)
        {
            if (LenghtTextBox.Text == "Enter Length here...")
            {
                LenghtTextBox.Text = "";
            }
        }

        private void feetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (feetCheckBox.Checked == false)
            {
                inchesCheckBox.Checked = true;
            }
            if (feetCheckBox.Checked == true)
            {
                inchesCheckBox.Checked = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public int countInstances(string str, char character)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    count++;
                }
            }

            return count;
        }
    }

    
}
