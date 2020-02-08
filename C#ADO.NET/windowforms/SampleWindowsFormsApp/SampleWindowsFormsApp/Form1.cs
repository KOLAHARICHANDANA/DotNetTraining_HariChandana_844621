using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good morning everybody,Have a Good Day!");

            if ((textFirst.Text == "") || (textSecond.Text == ""))
            {
                MessageBox.Show("fields cannot be blank,enter data", "input data");
            }


            else
            {
                double n1, n2;
                n1 = double.Parse(textFirst.Text);
                n2 = double.Parse(textSecond.Text);
                double result = 0;
                if (rdbadd2.Checked)
                {
                    result = (n1 + n2);
                    label3.Text = "sum:" + result;
                }
                else if (rdbsubtract2.Checked)
                {
                    result = (n1 - n2);
                    label3.Text = "sub:" + result;
                }
                else if (rdbmultiply2.Checked)
                {
                    result = (n1 * n2);
                    label3.Text = "multiply:" + result;
                }

                else if (rdbdivide2.Checked)
                {
                    result = (n1 / n2);
                    label3.Text = "divide:" + result;
                }
                else
                    label3.Text = "Enter your choice first";
            }
        }
    }
}
