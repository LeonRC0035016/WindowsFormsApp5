using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double SR6 = Convert.ToDouble(textBox4.Text);// these are where i make the inputs into variables
                double SR7 = Convert.ToDouble(textBox5.Text);
                double SR8 = 0.0;
                if (textBox6.Text == "0")
                    SR8 = double.PositiveInfinity;
                else
                    SR8 = Convert.ToDouble(textBox6.Text6.Text)
                        double SR9 = 0.0;
                if (textBox9.Text == "0")
                    SR9 = double.PositiveInfinity;// these are if staements to give an outcome when something specific happens
                else
                    SR9 = Convert.ToDouble(textBox9.Text);
                double SR10 = 0.0;
                if (textBox10.Text == "0")
                    SR10 = double.PositiveInfinity;
                else
                    SR10 = Convert.ToDouble(textBox10.Text):
                    double doubletotal = 1.0 / (1.0 / SR6 + 1.0 / SR7 + 1.0 / SR8 + 1.0 / SR9 + 1.0 / SR10);// this i where i apply the parallel formula to the variables 
                MessageBox.Show(doubletotal.ToString("0.00") + "ohms");
            }       // there is going to be a decimal and ohms at the end with this code 
                try
            {
                double SR1 = double.Parse(textBox1.Text);// this i where i make the series boxs into variables 
                double SR2 = double.Parse(textBox2.Text);
                double SR3 = double.Parse(textBox5.Text);
                double SR4 = double.Parse(textBox6.Text);
                double SR5 = double.Parse(textBox7.Text);


                double TR = SR1 + SR2 + SR3 + SR4 + SR5;
                MessageBox.Show("total resistance = " + TR.ToString("0.00") + "m");// this is where i apply series formula to the variables 
            }
            catch
            {
                MessageBox.Show("Invalid Input");

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double pR1 = double.Parse(textBox4.Text);
                double pR2 = double.Parse(textBox3.Text);
                double pR3 = double.Parse(textBox8.Text);
                double pR4 = double.Parse(textBox9.Text);
                double pR5 = double.Parse(textBox10.Text);
                // test the text box to see if there an infinity .
                double TR = 1/pR1 + 1/pR2 + 1/pR3 + 1 /pR4 + 1/pR5;
                MessageBox.Show("total resistance = " + TR.ToString("0.00") + "m");
            }   // the answer will appear as a message box
            catch
            {
                MessageBox.Show("Invalid Input");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
