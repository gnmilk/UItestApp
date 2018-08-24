using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UItestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            label3.Text = "輸入密碼後,按[Check]鈕";

            textBox2.Enabled = false;
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passward = "123456";
            if (textBox1.Text == passward)
            {
                label3.Text = "請輸入提款金額";
                textBox2.Enabled = true;
                button2.Enabled = true;
                textBox2.Focus();
            }
            else
            {
                label3.Text = "密碼錯誤,請重新輸入";
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(textBox2.Text);
            label3.Text = "您提領的金額是"+money+"元";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Form1_Load(sender,e);
        }
    }
}
