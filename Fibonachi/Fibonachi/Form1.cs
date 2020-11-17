using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, count;
            string text = ""; string text1 = "";
            a = Convert.ToInt32(maskedTextBox1.Text);
            count = Convert.ToInt32(maskedTextBox2.Text);
            for (int i = 0; i <= count; i++)
            {
                text += Convert.ToString(Fibonachi(a)) + " ";
                text1 += Convert.ToString(a) + " ";
                a += 1;
            }
            textBox2.Text = text1;
            textBox4.Text = text;
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
