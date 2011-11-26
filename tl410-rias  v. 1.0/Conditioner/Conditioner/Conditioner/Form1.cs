using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conditioner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string res="string>=5";
            /*
            Parser pr = new Parser("(((hight>3)&&(time==15))||(distance<45))");
            List<string> li;
            li = pr.getParsedConditions();
            foreach (string str in li)
            {
                res += str + @"
";
            }*/

            //textBox2.Text = res.Substring(0,1);
            int curHight = Convert.ToInt32(textBox3.Text);
            int curDistance = Convert.ToInt32(textBox4.Text);
            int curTime = Convert.ToInt32(textBox5.Text);

            EventExecutioner event1 = new EventExecutioner(textBox1.Text, curHight, curTime, curDistance);
            textBox2.Text = event1.executeEvent().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
