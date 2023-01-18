using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _0_1
{
    public partial class Form1 : Form
    {
        double a, b, c, d, x1, x2;
        public Form1()
        {
            InitializeComponent();
        }
        private void vvod()
        {
            a = Convert.ToDouble(nudA.Value);
            b = (double)nudB.Value;
            c = Convert.ToDouble(nudC.Value);
            d = b * b - 4 * a * c;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            vvod();
            if (d >= 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                txtX1.Text = (Math.Round(x1, 2)).ToString();
            }
            else
            {
                txtX1.Text = "нет корня";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vvod();
          
            if (d >= 0)
            {
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                txtX2.Text = Convert.ToString(x2);
            }
            else
            {
                txtX2.Text = "нет корня";
            }
        }
        
    }
}