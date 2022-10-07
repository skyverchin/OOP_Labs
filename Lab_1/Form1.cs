using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class TaskTest : Form
    {
        public TaskTest()
        {
            InitializeComponent();
        }
        private void InputA_TextChanged(object sender, EventArgs e){}
        private void InputB_TextChanged(object sender, EventArgs e){}
        private void InputC_TextChanged(object sender, EventArgs e){}

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, res = 0;

            a = double.Parse(InputA.Text);
            b = double.Parse(InputB.Text);
            c = double.Parse(InputC.Text);

            if (a <= 0 || b <= 0 || c <= 0)
            {
                MessageBox.Show("U are not UwU");
            }
            else
            {
                res = 0.5 * Math.Sqrt(4 * a * a - c * c);
                MessageBox.Show("Result = " + res);
            }
        }
    }
}
