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
        
        public ShowTime()
        {
            this.InitializeComponent();

            DateTime now = DateTime.Now;
            DateTime liu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 21, 23, 00);
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
            num6.Text = Convert.ToString((hor / 60) / 10);
            num7.Text = Convert.ToString((hor / 60) % 10);
            num1.Text = Convert.ToString((hor % 60) / 10);
            num2.Text = Convert.ToString((hor % 60) / 10);
            num4.Text = Convert.ToString((kun % 60) / 10);
            num5.Text = Convert.ToString((kun % 60) % 10);
        }
    }
}
