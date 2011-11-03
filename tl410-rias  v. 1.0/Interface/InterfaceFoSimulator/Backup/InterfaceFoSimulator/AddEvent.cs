using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfaceFoSimulator
{
 
    public struct EventData
    {
        public String name;
        public List<DataGridViewRow> listOfRows;
    }

    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();


            // заполения списка событий
            List<String> listEv = new List<string>();
            listEv.Add("Отказ левого двигателя");
            listEv.Add("Отказ правого двигателя");
            listEv.Add("Отказ системы управления");
            listEv.Add("Отказ системы охлаждения двигателей");
            listEv.Add("Отказ срабатываня шасси");
            listEv.Add("Турбулентность");
            listEv.Add("Отказ датчика высоты");
            listEv.Add("Отказ датчика скорости");
            listEv.Add("Терорист на самолете");
            SetListEvents(listEv);
                        
            // заполнение списка факторов
            List<String> listFac = new List<string>();
            listFac.Add("Время (мин)");
            listFac.Add("Высота (м)");
            listFac.Add("Далность (км)");
            SetListFactors(listFac);

            // заполнение списка умов
            List<String> listUm = new List<string>();
            listUm.Add("и");
            listUm.Add("или");
            listUm.Add("не");
            SetListYmov(listUm);
            

        }

        public void SetListEvents(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.ListOfEvents.Items.Add(list[i]);
        }
        public void SetListFactors(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.Column1.Items.Add(list[i]);
        }
        public void SetListYmov(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.Column3.Items.Add(list[i]);
        }


        public EventData getEventData()
        {

            EventData data = new EventData();
            data.listOfRows = new List<DataGridViewRow>();
            try
            {
                data.name = this.ListOfEvents.Items[this.ListOfEvents.SelectedIndex].ToString();
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    data.listOfRows.Add(this.dataGridView1.Rows[i]);
                }
            }
            catch
            {   
            }

            return data;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
