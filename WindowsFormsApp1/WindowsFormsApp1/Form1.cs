using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int s_timeCounr;
        public int s_allCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            s_allCount = Convert.ToInt32(cmbHourTime.Text) * 60 * 60 + Convert.ToInt32(cmbMinuteTime.Text) * 60;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            s_allCount = 60 * 60;
            this.timer1.Interval = 1000;
            labTimeCountDown.Text = "1:0:0";            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s_allCount -= 1;
            int hour = s_allCount / 3600;
            int minute = (s_allCount / 60) % 60;
            int second = s_allCount % 60;
            labTimeCountDown.Text = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString() ;
            if(s_allCount == 0)
            {
                timer1.Stop();
            }
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            s_allCount = Convert.ToInt32(cmbHourTime.Text) * 60 * 60 + Convert.ToInt32(cmbMinuteTime.Text) * 60;
        }
    }
}
