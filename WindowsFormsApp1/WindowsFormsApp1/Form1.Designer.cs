namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.labTimeCountDown = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.cmbHourTime = new System.Windows.Forms.ComboBox();
            this.cmbMinuteTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 15F);
            this.btnStart.Location = new System.Drawing.Point(35, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labTimeCountDown
            // 
            this.labTimeCountDown.AutoSize = true;
            this.labTimeCountDown.BackColor = System.Drawing.Color.Red;
            this.labTimeCountDown.Font = new System.Drawing.Font("宋体", 13F);
            this.labTimeCountDown.Location = new System.Drawing.Point(184, 41);
            this.labTimeCountDown.Name = "labTimeCountDown";
            this.labTimeCountDown.Size = new System.Drawing.Size(76, 22);
            this.labTimeCountDown.TabIndex = 1;
            this.labTimeCountDown.Text = "label1";
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("宋体", 15F);
            this.btnPause.Location = new System.Drawing.Point(35, 101);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(108, 66);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("宋体", 15F);
            this.btnStop.Location = new System.Drawing.Point(35, 186);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 66);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(417, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "时：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "分：";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Font = new System.Drawing.Font("宋体", 15F);
            this.btnSetTime.Location = new System.Drawing.Point(509, 12);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(108, 55);
            this.btnSetTime.TabIndex = 9;
            this.btnSetTime.Text = "设置";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // cmbHourTime
            // 
            this.cmbHourTime.FormattingEnabled = true;
            this.cmbHourTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbHourTime.Location = new System.Drawing.Point(442, 12);
            this.cmbHourTime.Name = "cmbHourTime";
            this.cmbHourTime.Size = new System.Drawing.Size(47, 23);
            this.cmbHourTime.TabIndex = 10;
            this.cmbHourTime.Text = "1";
            // 
            // cmbMinuteTime
            // 
            this.cmbMinuteTime.FormattingEnabled = true;
            this.cmbMinuteTime.Items.AddRange(new object[] {
            "0",
            "10",
            "30",
            "45"});
            this.cmbMinuteTime.Location = new System.Drawing.Point(442, 44);
            this.cmbMinuteTime.Name = "cmbMinuteTime";
            this.cmbMinuteTime.Size = new System.Drawing.Size(47, 23);
            this.cmbMinuteTime.TabIndex = 11;
            this.cmbMinuteTime.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 319);
            this.Controls.Add(this.cmbMinuteTime);
            this.Controls.Add(this.cmbHourTime);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.labTimeCountDown);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Learn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labTimeCountDown;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.ComboBox cmbHourTime;
        private System.Windows.Forms.ComboBox cmbMinuteTime;
    }
}

