using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Hours = 0;
        int Minutes = 0;
        int Seconds = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Form açılırken çalışacaklar
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Seconds++;

            if (Seconds == 60)
            {
                Minutes++;
                Seconds = 0;
            }

            if (Minutes == 60)
            {
                Hours++;
                Minutes = 0;
            }

            if (Seconds < 10)
            {
                labelSeconds.Text = "0" + Seconds;
            }
            else
            {
                labelSeconds.Text = Seconds.ToString();
            }

            if (Minutes < 10)
            {
                labelMinutes.Text = "0" + Minutes;
            }
            else
            {
                labelMinutes.Text = Minutes.ToString();
            }

            if (Hours < 10)
            {
                labelHours.Text = "0" + Hours;
            }
            else
            {
                labelHours.Text = Hours.ToString();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;

            labelHours.Text = "00";
            labelMinutes.Text = "00";
            labelSeconds.Text = "00";
        }
    }
}
