using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int a = 100, b = 1000;
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
            string kiss = cnt.ToString();
            label1.Text = kiss;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            

            string strText = textBox1.Text;
            int n = int.Parse(strText);
            if (n < 100)
            {
                MessageBox.Show("输入不合法");
            }
            else if (n >= 1000)
            {
                MessageBox.Show("输入不合法");
            }
            else if (n < a)
            {
                cnt++;
                string kiss = cnt.ToString();
                label1.Text = kiss;
                MessageBox.Show("小了!");
            }
            else if (n > b)
            {
                cnt++;
                string kiss = cnt.ToString();
                label1.Text = kiss;
                MessageBox.Show("大了！");
            }
            else if (a == b && n == a)
            {
                cnt++;
                string kiss = cnt.ToString();
                label1.Text = kiss;
                MessageBox.Show("Accept");
                cnt = 0;
                a = 100;
                b = 1000;
            }
            else if (n - a > b - n)
            {
                cnt++;
                string kiss = cnt.ToString();
                label1.Text = kiss;
                MessageBox.Show("大了！");
                b = n - 1;
            }
            else
            {
                cnt++;
                string kiss = cnt.ToString();
                label1.Text = kiss;
                MessageBox.Show("小了！");
                a = n + 1;
            }
        }
    }
}
