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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        XML xml = new XML(Application.StartupPath);
        Scenario scen = new Scenario(Application.StartupPath);

        private void button1_Click(object sender, EventArgs e)
        {
            Scenarios scenario = scen.Get_Scenario("temp.xml");
            scen.New_Scenario(textBox1.Text+".xml", scenario);
            scen.Edit_Scenario("тест2.xml", scenario);
            scen.test();
            MessageBox.Show("Виконання завершено!!!", "Повідомлення");
        }
    }
}
