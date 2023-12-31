using Microsoft.UI.Xaml.Controls;
using System;
using System.Windows.Threading;
using WaterShark.ViewModels;
using CommunityToolkit.WinUI.Controls;
using CommunityToolkit.WinUI.Behaviors;
using CommunityToolkit.WinUI;
using Microsoft.UI.Xaml;
using WaterShark.WindowForm;

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
        var notification = new Notification
        {
            Title = $"温馨提醒：",
            Message = "开始计时将会调起另一个新窗口实例。请注意：请勿中途关闭实例，否则计时将会归零",
            Severity = InfoBarSeverity.Informational,
        };

        NotificationQueue.Show(notification);
    }
    private void ClickLook(object sender, RoutedEventArgs e)
    {
        m_window = new ShowTime();
        m_window.Activate();
    }
    private Window m_window;


}
    
    

