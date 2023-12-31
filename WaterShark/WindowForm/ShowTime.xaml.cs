using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System.Windows.Threading;
using WaterShark.Helpers;
using System.Media;
using System.Diagnostics;
using Windows.UI;
using WaterShark.Contracts.Services;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WaterShark.WindowForm
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowTime : Window
    {
        private System.Windows.Threading.DispatcherTimer dispatcherTimer = null;
        int kun;
        int hour;
        int min;
        int sec;
        public ShowTime()
        {
            this.InitializeComponent();
            hour = 20;
            min = 22;
            sec = 55;
            subj.Text = "语文";

            DateTime now = DateTime.Now;
            DateTime liu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, min, sec);
            TimeSpan shi = liu - now;
            kun = (int)shi.TotalSeconds;

            display_number();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)//计时执行的程序
        {
            kun -= 1;
            if (kun == 0)
            {
                dispatcherTimer.Stop();
                return;
            }

            display_number();
        }

        private void display_number()
        {
            int mins = (kun / 60) / 10;
            int ming = (kun / 60) % 10;
            int hor = (mins * 10) + ming;

            int n6 = (hor / 60) / 10;
            int n7 = (hor / 60) % 10;
            int n1 = (hor % 60) / 10;
            int n2 = (hor % 60) % 10;
            int n4 = (kun % 60) / 10;
            int n5 = (kun % 60) % 10;
            num6.Text = Convert.ToString(n6);
            num7.Text = Convert.ToString(n7);
            num1.Text = Convert.ToString(n1);
            num2.Text = Convert.ToString(n2);
            num4.Text = Convert.ToString(n4);
            num5.Text = Convert.ToString(n5);

            if(n6 == 0 && n7 == 0 && n1 == 0 && n2 == 0 && n4 == 1 && n5 == 0)
            {
                num1.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                num2.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                num3.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                num4.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                num5.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                num6.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                num7.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                num8.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                SoundPlayer endding = new SoundPlayer();
                endding.SoundLocation = @"C:\Program Files (x86)\HiClass\HiteTools\Resource\CountDown.wav";
                endding.Load();
                endding.Play();
            }
            if (n6 == 0 && n7 == 0 && n1 == 0 && n2 == 0 && n4 == 0 && n5 == 1)
            {
                if (hour == 21 && min == 30 && sec == 00)
                {
                    subj.Text = "Null";
                    dispatcherTimer.Stop();
                    num5.Text = "0";
                    shutdown();
                }
                else if (hour == 21 && min == 22 && sec == 00)
                {
                    subj.Text = "化学";
                    min = 29;
                }
                else if (hour == 21 && min == 09 && sec == 00)
                {
                    subj.Text = "物理";
                    min = 21;
                }
                else if (hour == 20 && min == 46 && sec == 00)
                {
                    subj.Text = "英语";
                    hour = 21;
                    min = 08;
                }
                else if (hour == 20 && min == 23 && sec == 00)
                {
                    subj.Text = "数学";
                    min = 45;
                }
                DateTime now = DateTime.Now;
                DateTime liu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, min, sec);
                TimeSpan shi = liu - now;
                kun = (int)shi.TotalSeconds;
                num1.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
                num2.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
                num3.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
                num4.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
                num5.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
                num6.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
                num7.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
            }
        }
        public static void waitshut()
        {
            Thread.Sleep(10000);
            Process p = Process.Start("shutdown -s -t 0");
        }
        private async void shutdown()
        {
            var cd = new ContentDialog
            {
                Title = "关闭计算机",
                Content = "计算机将在10秒钟后关闭",
                PrimaryButtonText = "确定",
                SecondaryButtonText = "现在关闭",
                CloseButtonText = "取消",
                DefaultButton = ContentDialogButton.Primary
            }; 
            cd.XamlRoot = this.Content.XamlRoot;
            Thread sh = new Thread(waitshut);
            sh.Start();
            var result = await cd.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                //TODO: Add Notification 
            }
            else if (result == ContentDialogResult.Secondary)
            {
                Process p = Process.Start("shutdown -s -t 0");
            }
            //else
            //{
                //DialogResult.Text = "User cancelled the dialog";
            //}
        }
    }
}
