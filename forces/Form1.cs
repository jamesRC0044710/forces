using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double angle = sin(x);
                label1.Text = "Angle = " + angle;
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        
           double cos (double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

          double acos (double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }
          double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));

        }
          double atan(double x)
        {
            return (Math.Atan(x) * 180 / Math.PI);
        }
    }
}
