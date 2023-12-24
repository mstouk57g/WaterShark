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
            min = 23;
            sec = 00;

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
                SoundPlayer endding = new SoundPlayer();
                endding.SoundLocation = @"C:\Program Files (x86)\HiClass\HiteTools\Resource\CountDown.wav";
                endding.Load();
                endding.Play();
            }
            if (n6 == 0 && n7 == 0 && n1 == 0 && n2 == 0 && n4 == 0 && n5 == 1)
            {
                num5.Text = "0";
                Thread.Sleep(1000);
                if (hour == 21 && min == 30 && sec == 00)
                {
                    HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/args?arg=" + hour + "-" + min + "-" + sec + "5");
                    shutdown();
                }
                if (hour == 21 && min == 22 && sec == 00)
                {
                    HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/args?arg=" + hour + "-" + min + "-" + sec + "4");
                    min = 30;
                }
                if (hour == 21 && min == 09 && sec == 00)
                {
                    HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/args?arg=" + hour + "-" + min + "-" + sec + "3");
                    min = 22;
                }
                if (hour == 20 && min == 46 && sec == 00)
                {
                    HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/args?arg=" + hour + "-" + min + "-" + sec + "2");
                    hour = 21;
                    min = 09;
                }
                HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/args?arg=" + hour + "-" + min + "-" + sec + "0");
                if (hour == 20 && min == 23 && sec == 00)
                {
                    HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/args?arg=" + hour + "-" + min + "-" + sec + "1");
                    min = 46;
                }
                DateTime now = DateTime.Now;
                HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/args?arg=" now.ToString);
                DateTime liu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, min, sec);
                TimeSpan shi = liu - now;
                kun = (int)shi.TotalSeconds;
            }
        }
        private async void shutdown()
        {
            var cd = new ContentDialog
            {
                Title = "Button Clicker!",
                Content = "You clicked the button!",
                PrimaryButtonText = "Save",
                SecondaryButtonText = "Don't Save",
                CloseButtonText = "Ok",
                DefaultButton = ContentDialogButton.Primary
            };
            cd.XamlRoot = this.Content.XamlRoot;
            var result = await cd.ShowAsync();

        }
    }
}
