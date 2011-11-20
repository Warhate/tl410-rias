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
        public bool itsAllOk;

        public AddEvent()
        {
            InitializeComponent();

            itsAllOk = false;
            SetAllData();

        }

        public void SetAllData()
        {
            Container ContainerOfData = new Container();

            SetListEvents(ContainerOfData.GetListEvents());
            SetListFactors(ContainerOfData.GetListFactors());
            SetListCondition(ContainerOfData.GetListCondition());
            SetListOp(ContainerOfData.GetListOp());

        }

        private void SetListEvents(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.ListOfEvents.Items.Add(list[i]);
        }
        private void SetListFactors(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.Column1.Items.Add(list[i]);
        }
        private void SetListCondition(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.Column3.Items.Add(list[i]);
        }
        private void SetListOp(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.Column4.Items.Add(list[i]);
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
            // проверка на пустые поля
            try
            {
                int k = 0;
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (this.dataGridView1["Column1", i].Value.ToString() == ""
                        || this.dataGridView1["Column2", i].Value.ToString() == ""
                        || this.dataGridView1["Column4", i].Value.ToString() == "") k++;
                }

                if (this.ListOfEvents.Text == "" || k != 0 || this.dataGridView1.RowCount < 2)
                    MessageBox.Show("Заполните все данные!");
                else
                {
                    this.Close();
                    itsAllOk = true;
                }
            }
            catch
            {
                MessageBox.Show("Заполните все данные!");
            }
        }

       
    }
}
