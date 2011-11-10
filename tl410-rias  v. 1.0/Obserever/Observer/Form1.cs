using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        State state;
        

        public Form1()
        {
            state = new State();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvent(txtHeight.Text,txtSpeed.Text,txtName.Text);
        }

        private void AddEvent(string height, string speed, string name)
        {
            AviaEvent eve = new AviaEvent(state,name);
            if (!String.IsNullOrWhiteSpace(height))
            { 
                try{
                eve.Height=Convert.ToSingle(height);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                
                }

            
            }

            if (!String.IsNullOrWhiteSpace(speed))
            {
                try
                {
                    eve.Speed = Convert.ToSingle(speed);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

            state.Attach(eve);
            listBoxEvent.Items.Add(eve.Name);



        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Change(float height, float speed)
        {
            Change(height.ToString(), speed.ToString());
        }

        private void Change(string height, string speed)
        {

            if (!String.IsNullOrWhiteSpace(height))
            {
                try
                {
                    state.Height = Convert.ToSingle(height);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

            if (!String.IsNullOrWhiteSpace(speed))
            {
                try
                {
                    state.Speed = Convert.ToSingle(speed);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

            state.Notify();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Change(rand.Next(0, 100), rand.Next(0, 100));
        }


    }
}
