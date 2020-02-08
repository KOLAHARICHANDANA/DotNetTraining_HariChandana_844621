using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsAppProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good morning everybody,Have a Good Day!");

            if ((txtFirst.Text == "") || (txt2.Text == "")) ;
            {
                MessageBox.Show("fields cannot be blank,enter data", "input data");
            }
            else
            {
                double n1, n2;
                n1 = double.Parse(txtFirst.Text);
                n2 = double.Parse(txtFirst.Text);
                double result = 0;
                if(rdbadd1.Checked)
                {
                    result = (n1 + n2);
                    lblSolution.Text = "sum:" + result;
                }


            }


            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Subtract_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
