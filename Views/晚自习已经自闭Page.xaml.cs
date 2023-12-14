using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using CommunityToolkit.WinUI.Controls;
using System.Threading;
using WaterShark.ViewModels;

namespace WaterShark.Views;


public sealed partial class 晚自习已经自闭Page : Page
{
    //int minb = 22;
    //int secs = 59;
    //int minm = 12;
    //int mins = 7;

    public 晚自习已经自闭ViewModel ViewModel
    {
        get;
    }

    public 晚自习已经自闭Page()
    {
        ViewModel = App.GetService<晚自习已经自闭ViewModel>();
        InitializeComponent();
    }
    private async void ClickStart(object sender, RoutedEventArgs e)
    {
        Start.Content = "结束"; //
        for (int minb = 0; minb >= 0; minb--)
        {
            string m = minb.ToString();
            min.Text = m;
            for (int secs = 10; secs >= 0; secs--)
            {
                string s = secs.ToString();
                sec.Text = s;
                Thread.Sleep(1000);
            }
        }
        var cd = new ContentDialog
        {
            Title = "计时结束",
            Content = "",
            PrimaryButtonText = "Ok",
            DefaultButton = ContentDialogButton.Primary
        };
        cd.XamlRoot = this.Content.XamlRoot;
        var result = await cd.ShowAsync();
    }
}
