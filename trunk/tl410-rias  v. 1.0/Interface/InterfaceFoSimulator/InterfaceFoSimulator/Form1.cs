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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // заполения списка направлений ветра
            List<String> list = new List<string>();
            list.Add("Южное");
            list.Add("Северное");
            list.Add("Западное");
            list.Add("Восточное");
            SetListVeter(list);
        }

        public void SetListVeter(List<String> list)
        {
            for (int i = 0; i < list.Count; i++)
                this.comboBoxCourse.Items.Add(list[i]);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMassa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxObl = new System.Windows.Forms.TextBox();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDav = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxVla = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataEventsTable = new System.Windows.Forms.DataGridView();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEventsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название сценария";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(126, 15);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(602, 20);
            this.textBox1Name.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(15, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 312);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Начальные условия";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxMassa);
            this.groupBox4.Location = new System.Drawing.Point(288, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 156);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ЛА";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Вес (кг)";
            // 
            // textBoxMassa
            // 
            this.textBoxMassa.Location = new System.Drawing.Point(97, 16);
            this.textBoxMassa.Name = "textBoxMassa";
            this.textBoxMassa.Size = new System.Drawing.Size(100, 20);
            this.textBoxMassa.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxObl);
            this.groupBox3.Controls.Add(this.textBoxTemp);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxDav);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxVla);
            this.groupBox3.Location = new System.Drawing.Point(17, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 156);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Метеорологические";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Температура (С\')";
            // 
            // textBoxObl
            // 
            this.textBoxObl.Location = new System.Drawing.Point(138, 123);
            this.textBoxObl.Name = "textBoxObl";
            this.textBoxObl.Size = new System.Drawing.Size(61, 20);
            this.textBoxObl.TabIndex = 14;
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(138, 26);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(61, 20);
            this.textBoxTemp.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Облачность (баллы)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Давление (рт. ст.)";
            // 
            // textBoxDav
            // 
            this.textBoxDav.Location = new System.Drawing.Point(138, 61);
            this.textBoxDav.Name = "textBoxDav";
            this.textBoxDav.Size = new System.Drawing.Size(61, 20);
            this.textBoxDav.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Влажность (%)";
            // 
            // textBoxVla
            // 
            this.textBoxVla.Location = new System.Drawing.Point(138, 93);
            this.textBoxVla.Name = "textBoxVla";
            this.textBoxVla.Size = new System.Drawing.Size(61, 20);
            this.textBoxVla.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBoxCourse);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxSpeed);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(288, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 89);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ветер";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "м/с";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(96, 20);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCourse.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Направление";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(96, 58);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(80, 20);
            this.textBoxSpeed.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Скорость";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxY2);
            this.groupBox1.Controls.Add(this.textBoxX2);
            this.groupBox1.Controls.Add(this.textBoxY1);
            this.groupBox1.Controls.Add(this.textBoxX1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координаты";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(190, 61);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(48, 20);
            this.textBoxY2.TabIndex = 9;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(106, 61);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(51, 20);
            this.textBoxX2.TabIndex = 8;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(190, 26);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(48, 20);
            this.textBoxY1.TabIndex = 7;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(106, 26);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(51, 20);
            this.textBoxX1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Х";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Конечные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Начальные";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RemoveButton);
            this.tabPage2.Controls.Add(this.AddButton);
            this.tabPage2.Controls.Add(this.dataEventsTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "События";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(624, 77);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 41);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(624, 16);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 44);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataEventsTable
            // 
            this.dataEventsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEventsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataEventsTable.Location = new System.Drawing.Point(17, 16);
            this.dataEventsTable.Name = "dataEventsTable";
            this.dataEventsTable.Size = new System.Drawing.Size(589, 252);
            this.dataEventsTable.TabIndex = 0;
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(632, 364);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(92, 23);
            this.Closebutton.TabIndex = 2;
            this.Closebutton.Text = "ОК";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Умова";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(740, 399);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Сценарий";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEventsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEventToTable();
        }

        private void AddEventToTable()
        {
            AddEvent newEvent = new AddEvent();
            newEvent.ShowDialog();

            if (newEvent.itsAllOk == true)
            {
                // получаем данные о событии и записываем в таблицу
                EventData evdata = newEvent.getEventData();
                // додаем новые столбцы
                for (int i = 0; i < evdata.listOfRows.Count; i++)
                {
                    if (this.dataEventsTable.Columns.Contains(evdata.listOfRows[i].Cells[0].Value.ToString()) == false)
                    {
                        DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                        newColumn.DataPropertyName = evdata.listOfRows[i].Cells[0].Value.ToString();
                        newColumn.HeaderText = evdata.listOfRows[i].Cells[0].Value.ToString();
                        newColumn.Width = 70;
                        newColumn.Name = evdata.listOfRows[i].Cells[0].Value.ToString();

                        this.dataEventsTable.Columns.Add(newColumn);
                    }
                }

                this.dataEventsTable.Rows.Add();

                // заполняем данными
                this.dataEventsTable.Rows[this.dataEventsTable.RowCount - 2].Cells[0].Value = evdata.name;

                String Condition = "";
                for (int i = 0; i < evdata.listOfRows.Count; i++)
                {
                    Condition = Condition + "'" + evdata.listOfRows[i].Cells[0].Value.ToString() + "'" + evdata.listOfRows[i].Cells[1].Value.ToString() + evdata.listOfRows[i].Cells[2].Value.ToString();
                    if (evdata.listOfRows[i].Cells[3].Value != null)
                        Condition = Condition + " " + evdata.listOfRows[i].Cells[3].Value.ToString() + " ";
                }
                this.dataEventsTable.Rows[this.dataEventsTable.RowCount - 2].Cells[1].Value = Condition;

                for (int i = 0; i < evdata.listOfRows.Count; i++)
                {
                    if (evdata.listOfRows[i].Cells[1].Value == null)
                        this.dataEventsTable.Rows[this.dataEventsTable.RowCount - 2].Cells[evdata.listOfRows[i].Cells[0].Value.ToString()].Value = "";
                    else
                        this.dataEventsTable.Rows[this.dataEventsTable.RowCount - 2].Cells[evdata.listOfRows[i].Cells[0].Value.ToString()].Value = evdata.listOfRows[i].Cells[2].Value.ToString();
                }

            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> DicStatScenary = GetStaticOptionsOfScenary();
            Dictionary<String, String> DicEvents = GetEvents();

            // отсылаем структуру дальше "Максу" !!!
            // ...

            this.Close();
        }

        private String RezultCondition(String str)
        {
            str = str.Replace(" и ", ")&&(");
            str = str.Replace(" или ", ")||(");
            str = str.Replace("'Высота (м)'", "hight");
            str = str.Replace("'Время (мин)'", "time");
            str = str.Replace("'Далность (км)'", "distance");
            str = "(" + str + ")";

            return str;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Удалить событие?");
                int i = dataEventsTable.SelectedCells[0].RowIndex;
                dataEventsTable.Rows.RemoveAt(i);
            }
            catch
            {
                MessageBox.Show("Невозможная операция");
            }
        }

        public Dictionary<String, String> GetEvents()
        {
            Dictionary<String, String> DictEvents = new Dictionary<string, string>();

            for (int i = 0; i < this.dataEventsTable.Rows.Count - 1; i++)
                DictEvents.Add(this.dataEventsTable.Rows[i].Cells[0].Value.ToString(), RezultCondition(this.dataEventsTable.Rows[i].Cells[1].Value.ToString()));


            return DictEvents;
        }

        public Dictionary<String, String> GetStaticOptionsOfScenary()
        {
            Dictionary<String, String> DictEvents = new Dictionary<string, string>();

            DictEvents.Add("name", this.textBox1Name.Text);
            DictEvents.Add("x1", this.textBoxX1.Text);
            DictEvents.Add("x2", this.textBoxX2.Text);
            DictEvents.Add("y1", this.textBoxY1.Text);
            DictEvents.Add("y2", this.textBoxY2.Text);
            DictEvents.Add("temp", this.textBoxTemp.Text);
            DictEvents.Add("dav", this.textBoxDav.Text);
            DictEvents.Add("vla", this.textBoxVla.Text);
            DictEvents.Add("obl", this.textBoxObl.Text);
            DictEvents.Add("masa", this.textBoxMassa.Text);
            DictEvents.Add("naprav", this.comboBoxCourse.Text);
            DictEvents.Add("speed", this.textBoxSpeed.Text);

            return DictEvents;
        }
    }
}
