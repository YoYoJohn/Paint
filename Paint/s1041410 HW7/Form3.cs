using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1041410_HW7
{
    public partial class Form3 : Form
    {
        float R_value, G_value, B_value, A_value;
        float r, g, b, a;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R_value = trackBar1.Value;
            G_value = trackBar2.Value;
            B_value = trackBar3.Value;
            A_value = trackBar4.Value;
            r = R_value / 10;
            g = G_value / 10;
            b = B_value / 10;
            a = A_value / 10;
            this.Close();
        }

        public float getR()
        {
            return r;
        }
        public float getG()
        {
            return g;
        }
        public float getB()
        {
            return b;
        }
        public float getA()
        {
            return a;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R_value = trackBar1.Value;
            r=R_value/10;
            label5.Text = r.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G_value = trackBar2.Value;
            g = G_value/10;
            label6.Text = g.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B_value = trackBar3.Value;
            b = B_value/10;
            label7.Text = b.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            A_value = trackBar4.Value;
            a = A_value/10;
            label8.Text = a.ToString();
        }

    }
}
