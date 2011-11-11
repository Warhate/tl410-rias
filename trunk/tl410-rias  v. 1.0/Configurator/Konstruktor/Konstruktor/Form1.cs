using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Konstruktor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XML xml = new XML(Application.StartupPath);

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mas = xml.load_settings(Application.StartupPath + @"\test.xml");
            xml.add_actions(Application.StartupPath + @"\" + textBox1.Text + ".xml", mas);
            MessageBox.Show("Виконання завершено!!!", "Повідомлення");
        }
    }
}
