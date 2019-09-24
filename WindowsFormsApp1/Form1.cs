using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Quadratic : Form
    {
        public Quadratic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double c = double.Parse(textBoxC.Text);
            if (Math.Pow(b, 2) >= 4 * a * c)
            {
                double quad1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                double quad2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                string quad1Text = quad1.ToString("0.0000");
                string quad2Text = quad2.ToString("0.0000");
                zero1Box.Text = quad1Text;
                zero2Box.Text = quad2Text;
            }
            else
            {
                double quad1Real = (-b / (2 * a));
                double quad2Real = (-b / (2 * a));
                double quad1Imag = (Math.Sqrt(-(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
                double quad2Imag = (- Math.Sqrt(-(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
                string quad1RealText = quad1Real.ToString("0.000");
                string quad2RealText = quad2Real.ToString("0.000");
                string quad1ImagText = quad1Imag.ToString("0.000");
                string quad2ImagText = quad2Imag.ToString("0.000");
                zero1Box.Text = quad1RealText + " + i" + quad1ImagText;
                zero2Box.Text = quad2RealText + " + i" + quad2ImagText;
            }
            
            
            
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quadratic_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
