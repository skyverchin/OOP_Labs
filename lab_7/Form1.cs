using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7
{

    public partial class Form1 : Form
    {
        Graphics Graph;
        Pen RoundPen;
        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Color slateBlue = Color.FromName("SlateBlue");
            float width = 3;
            RoundPen = new Pen(slateBlue, width);
            double y, y2, x;
            double tmp1 = 0.1, tmp2 = 1.5, tmp3 = 0.2;

            int formHeight = this.Height;
            int formWidth = this.Width;

            if (formWidth <= 500 || formHeight <= 500)
            {
                tmp1 *= 10;
                tmp2 *= 10;
                tmp3 *= 10;
            }
            else if (formWidth >= 500 || formHeight >= 500)
            {
                tmp1 *= 100;
                tmp2 *= 100;
                tmp3 *= 100;
            }

            string test1 = Convert.ToString(formWidth);
            string test2 = Convert.ToString(formHeight);
            MessageBox.Show(test1, test2);

            y = 0;
            x = 0;
            for (double x2 = tmp1; x2 <= tmp2; x2 += tmp3)
            {
                y2 = (3*x2+1)/Math.Atan(x2);
                float xf = Convert.ToSingle(x);
                float yf = Convert.ToSingle(y);
                float x2f = Convert.ToSingle(x2);
                float y2f = Convert.ToSingle(y2);
                Graph.DrawLine(RoundPen, xf, yf, x2f, y2f);
                /*x = x2;
                y = y2;*/
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}