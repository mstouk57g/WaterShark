using Microsoft.UI.Xaml.Controls;
using System;
using System.Windows;
using System.Windows.Threading;
using WaterShark.ViewModels;


namespace WaterShark.Views;


public sealed partial class 晚自习已经自闭Page : Page
{
   public 晚自习已经自闭ViewModel ViewModel
    {
        get;
    }

    public 晚自习已经自闭Page()
    {
        ViewModel = App.GetService<晚自习已经自闭ViewModel>();
        InitializeComponent();
        DispatcherTimer timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += timer_Tick;
        timer.Start();
    }
    void timer_Tick(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToLongTimeString();
    }
    
}
