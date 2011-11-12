namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddState = new System.Windows.Forms.Button();
            this.textBoxStateName = new System.Windows.Forms.TextBox();
            this.textBoxStateVal = new System.Windows.Forms.TextBox();
            this.textBoxEveParNam = new System.Windows.Forms.TextBox();
            this.textBoxEvParVAl = new System.Windows.Forms.TextBox();
            this.buttonAddEvParam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxEvParam = new System.Windows.Forms.ListBox();
            this.buttonAddEv = new System.Windows.Forms.Button();
            this.textBoxEvNam = new System.Windows.Forms.TextBox();
            this.listBoxState = new System.Windows.Forms.ListBox();
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddState
            // 
            this.buttonAddState.Location = new System.Drawing.Point(244, 12);
            this.buttonAddState.Name = "buttonAddState";
            this.buttonAddState.Size = new System.Drawing.Size(151, 23);
            this.buttonAddState.TabIndex = 0;
            this.buttonAddState.Text = "Додати параметр";
            this.buttonAddState.UseVisualStyleBackColor = true;
            this.buttonAddState.Click += new System.EventHandler(this.buttonAddState_Click);
            // 
            // textBoxStateName
            // 
            this.textBoxStateName.Location = new System.Drawing.Point(32, 12);
            this.textBoxStateName.Name = "textBoxStateName";
            this.textBoxStateName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStateName.TabIndex = 1;
            // 
            // textBoxStateVal
            // 
            this.textBoxStateVal.Location = new System.Drawing.Point(138, 12);
            this.textBoxStateVal.Name = "textBoxStateVal";
            this.textBoxStateVal.Size = new System.Drawing.Size(100, 20);
            this.textBoxStateVal.TabIndex = 2;
            // 
            // textBoxEveParNam
            // 
            this.textBoxEveParNam.Location = new System.Drawing.Point(10, 19);
            this.textBoxEveParNam.Name = "textBoxEveParNam";
            this.textBoxEveParNam.Size = new System.Drawing.Size(100, 20);
            this.textBoxEveParNam.TabIndex = 3;
            // 
            // textBoxEvParVAl
            // 
            this.textBoxEvParVAl.Location = new System.Drawing.Point(116, 19);
            this.textBoxEvParVAl.Name = "textBoxEvParVAl";
            this.textBoxEvParVAl.Size = new System.Drawing.Size(100, 20);
            this.textBoxEvParVAl.TabIndex = 4;
            // 
            // buttonAddEvParam
            // 
            this.buttonAddEvParam.Location = new System.Drawing.Point(222, 19);
            this.buttonAddEvParam.Name = "buttonAddEvParam";
            this.buttonAddEvParam.Size = new System.Drawing.Size(151, 23);
            this.buttonAddEvParam.TabIndex = 5;
            this.buttonAddEvParam.Text = "Додати параметр";
            this.buttonAddEvParam.UseVisualStyleBackColor = true;
            this.buttonAddEvParam.Click += new System.EventHandler(this.buttonAddEvParam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEvNam);
            this.groupBox1.Controls.Add(this.buttonAddEv);
            this.groupBox1.Controls.Add(this.listBoxEvParam);
            this.groupBox1.Controls.Add(this.textBoxEvParVAl);
            this.groupBox1.Controls.Add(this.buttonAddEvParam);
            this.groupBox1.Controls.Add(this.textBoxEveParNam);
            this.groupBox1.Location = new System.Drawing.Point(22, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подія";
            // 
            // listBoxEvParam
            // 
            this.listBoxEvParam.FormattingEnabled = true;
            this.listBoxEvParam.Location = new System.Drawing.Point(10, 45);
            this.listBoxEvParam.Name = "listBoxEvParam";
            this.listBoxEvParam.Size = new System.Drawing.Size(363, 121);
            this.listBoxEvParam.TabIndex = 6;
            // 
            // buttonAddEv
            // 
            this.buttonAddEv.Location = new System.Drawing.Point(298, 173);
            this.buttonAddEv.Name = "buttonAddEv";
            this.buttonAddEv.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEv.TabIndex = 7;
            this.buttonAddEv.Text = "Додати";
            this.buttonAddEv.UseVisualStyleBackColor = true;
            this.buttonAddEv.Click += new System.EventHandler(this.buttonAddEv_Click);
            // 
            // textBoxEvNam
            // 
            this.textBoxEvNam.Location = new System.Drawing.Point(10, 175);
            this.textBoxEvNam.Name = "textBoxEvNam";
            this.textBoxEvNam.Size = new System.Drawing.Size(282, 20);
            this.textBoxEvNam.TabIndex = 8;
            // 
            // listBoxState
            // 
            this.listBoxState.FormattingEnabled = true;
            this.listBoxState.Location = new System.Drawing.Point(407, 12);
            this.listBoxState.Name = "listBoxState";
            this.listBoxState.Size = new System.Drawing.Size(284, 56);
            this.listBoxState.TabIndex = 7;
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.Location = new System.Drawing.Point(407, 99);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(284, 199);
            this.listBoxEvent.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 275);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 311);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxEvent);
            this.Controls.Add(this.listBoxState);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxStateVal);
            this.Controls.Add(this.textBoxStateName);
            this.Controls.Add(this.buttonAddState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddState;
        private System.Windows.Forms.TextBox textBoxStateName;
        private System.Windows.Forms.TextBox textBoxStateVal;
        private System.Windows.Forms.TextBox textBoxEveParNam;
        private System.Windows.Forms.TextBox textBoxEvParVAl;
        private System.Windows.Forms.Button buttonAddEvParam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEvNam;
        private System.Windows.Forms.Button buttonAddEv;
        private System.Windows.Forms.ListBox listBoxEvParam;
        private System.Windows.Forms.ListBox listBoxState;
        private System.Windows.Forms.ListBox listBoxEvent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

