using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Media;
using System.Runtime.CompilerServices;

namespace DinnerTime
{
    public partial class Form1 : Form
    {
        int mint = 20;
        int scss = 0;
        public Form1()
        {
            InitializeComponent();


            this.label1.Text = mint.ToString("D2") + ":";
            this.label2.Text = scss.ToString("D2");

            this.label1.Font = new Font("Microsoft Sans Serif", 100);
            this.label2.Font = new Font("Microsoft Sans Serif", 100);
            this.label3.Font = new Font("Microsoft Sans Serif", 100);

            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(timer1_Tick);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mint >= 0)
            {
                if (scss == 0)
                {
                    label2.Text = scss.ToString("D2");
                    mint--;
                    scss = 59;
                }
                else
                {
                    label1.Text = mint.ToString("D2");
                    label2.Text = scss.ToString("D2"); 
                    scss--;
                }
            }
            if (mint == 0 & scss == 9)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                SoundPlayer endding = new SoundPlayer();
                endding.SoundLocation = @"C:\Program Files (x86)\HiClass\HiteTools\Resource\CountDown.wav";
                endding.Load();
                endding.Play();
            }
            if (mint == 1 & scss == 9)
            {
                Process p = Process.Start("tskill msedge");
                p.Kill();
                label1.ForeColor = Color.Orange;
                label2.ForeColor = Color.Orange;
                label3.ForeColor = Color.Orange;
                SoundPlayer endding = new SoundPlayer();
                endding.SoundLocation = @"C:\Program Files (x86)\HiClass\HiteTools\Resource\CountDown.wav";
                endding.Load();
                endding.Play();
            }
        }
        /// <summary>
        /// 鼠标按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Point mPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void exitclick(object sender, MouseEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
