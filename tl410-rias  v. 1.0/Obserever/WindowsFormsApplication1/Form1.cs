using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Observer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SortedList<String, String> _evparam;
        private EventManager _manager;
        private Random _rnd;

        public Form1()
        {
            _manager = new EventManager();
            _evparam = new SortedList<string, string>();
            _rnd = new Random();
            InitializeComponent();
        }

        private void buttonAddState_Click(object sender, EventArgs e)
        {
            _manager.State.AddParam(textBoxStateName.Text, textBoxStateVal.Text);
            listBoxState.Items.Add(String.Format("{0} = {1}",textBoxStateName.Text,textBoxStateVal.Text));


        }

        private void buttonAddEvParam_Click(object sender, EventArgs e)
        {
            _evparam.Add(textBoxEveParNam.Text,textBoxEvParVAl.Text);
            listBoxEvParam.Items.Add(String.Format("{0} = {1}", textBoxEveParNam.Text, textBoxEvParVAl.Text));
        }

        private void buttonAddEv_Click(object sender, EventArgs e)
        {
            _manager.AddEvent(textBoxEvNam.Text, _evparam);
            listBoxEvent.Items.Add(textBoxEvNam.Text);
            listBoxEvParam.Items.Clear();
            //_evparam.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var temp = new SortedList<string, string>();
            temp.Clear();

            foreach(var par in _manager.State.Parameters)
            {

                temp.Add(par.Key, _rnd.Next(0, 200).ToString());

               
            }

            foreach (var par in temp)
            {

                _manager.ChangeStateParam(par.Key,
                                         par.Value);


            }

            

            ShowParam();
        }

        private void ShowParam()
        {
            listBoxState.Items.Clear();

            foreach (var par in _manager.State.Parameters)
            {
                listBoxState.Items.Add(String.Format("{0} = {1}", par.Key, par.Value));
            }

            
        }
    }
}
