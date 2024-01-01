using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using Newtonsoft.Json.Linq;
using WaterShark.ViewModels;
using Newtonsoft.Json;
using Windows.Media.AppBroadcasting;
using System.Net;
using System.Text;
using WaterShark.WindowForm;
using System.Diagnostics;
using Microsoft.UI.Xaml.Controls.Primitives;
using WaterShark.Helpers;

namespace WaterShark.Views;

public sealed partial class 大课间写名字Page : Page
{

    //string jsonfile = "C:/Test/test.json";
    List<string> namelist = new List<string>();
    public 大课间写名字ViewModel ViewModel
    {
        get;
    }
    
    public static 大课间写名字Page 大课间写名字;
    public 大课间写名字Page()
    {
        ViewModel = App.GetService<大课间写名字ViewModel>();
        InitializeComponent();
        大课间写名字 = this;
        ContentArea.Visibility = Visibility.Collapsed;
        A1.Content = App.Global.A1;
        A2.Content = App.Global.A2;
        A3.Content = App.Global.A3;
        A4.Content = App.Global.A4;
        A5.Content = App.Global.A5;
        A6.Content = App.Global.A6;
        A7.Content = App.Global.A7;
        A8.Content = App.Global.A8;

        B1.Content = App.Global.B1;
        B2.Content = App.Global.B2;
        B3.Content = App.Global.B3;
        B4.Content = App.Global.B4;
        B5.Content = App.Global.B5;
        B6.Content = App.Global.B6;
        B7.Content = App.Global.B7;
        B8.Content = App.Global.B8;

        C1.Content = App.Global.C1;
        C2.Content = App.Global.C2;
        C3.Content = App.Global.C3;
        C4.Content = App.Global.C4;
        C5.Content = App.Global.C5;
        C6.Content = App.Global.C6;
        C7.Content = App.Global.C7;
        C8.Content = App.Global.C8;

        D1.Content = App.Global.D1;
        D2.Content = App.Global.D2;
        D3.Content = App.Global.D3;
        D4.Content = App.Global.D4;
        D5.Content = App.Global.D5;
        D6.Content = App.Global.D6;
        D7.Content = App.Global.D7;
        D8.Content = App.Global.D8;

        E1.Content = App.Global.E1;
        E2.Content = App.Global.E2;
        E3.Content = App.Global.E3;
        E4.Content = App.Global.E4;
        E5.Content = App.Global.E5;
        E6.Content = App.Global.E6;
        E7.Content = App.Global.E7;
        E8.Content = App.Global.E8;

        F1.Content = App.Global.F1;
        F2.Content = App.Global.F2;
        F3.Content = App.Global.F3;
        F4.Content = App.Global.F4;
        F5.Content = App.Global.F5;
        F6.Content = App.Global.F6;
        F7.Content = App.Global.F7;
        F8.Content = App.Global.F8;

        A1.IsEnabled = Convert.ToBoolean(App.Global.TA1);
        A2.IsEnabled = Convert.ToBoolean(App.Global.TA2);
        A3.IsEnabled = Convert.ToBoolean(App.Global.TA3);
        A4.IsEnabled = Convert.ToBoolean(App.Global.TA4);
        A5.IsEnabled = Convert.ToBoolean(App.Global.TA5);
        A6.IsEnabled = Convert.ToBoolean(App.Global.TA6);
        A7.IsEnabled = Convert.ToBoolean(App.Global.TA7);
        A8.IsEnabled = Convert.ToBoolean(App.Global.TA8);

        B1.IsEnabled = Convert.ToBoolean(App.Global.TB1);
        B2.IsEnabled = Convert.ToBoolean(App.Global.TB2);
        B3.IsEnabled = Convert.ToBoolean(App.Global.TB3);
        B4.IsEnabled = Convert.ToBoolean(App.Global.TB4);
        B5.IsEnabled = Convert.ToBoolean(App.Global.TB5);
        B6.IsEnabled = Convert.ToBoolean(App.Global.TB6);
        B7.IsEnabled = Convert.ToBoolean(App.Global.TB7);
        B8.IsEnabled = Convert.ToBoolean(App.Global.TB8);

        C1.IsEnabled = Convert.ToBoolean(App.Global.TC1);
        C2.IsEnabled = Convert.ToBoolean(App.Global.TC2);
        C3.IsEnabled = Convert.ToBoolean(App.Global.TC3);
        C4.IsEnabled = Convert.ToBoolean(App.Global.TC4);
        C5.IsEnabled = Convert.ToBoolean(App.Global.TC5);
        C6.IsEnabled = Convert.ToBoolean(App.Global.TC6);
        C7.IsEnabled = Convert.ToBoolean(App.Global.TC7);
        C8.IsEnabled = Convert.ToBoolean(App.Global.TC8);

        D1.IsEnabled = Convert.ToBoolean(App.Global.TD1);
        D2.IsEnabled = Convert.ToBoolean(App.Global.TD2);
        D3.IsEnabled = Convert.ToBoolean(App.Global.TD3);
        D4.IsEnabled = Convert.ToBoolean(App.Global.TD4);
        D5.IsEnabled = Convert.ToBoolean(App.Global.TD5);
        D6.IsEnabled = Convert.ToBoolean(App.Global.TD6);
        D7.IsEnabled = Convert.ToBoolean(App.Global.TD7);
        D8.IsEnabled = Convert.ToBoolean(App.Global.TD8);

        E1.IsEnabled = Convert.ToBoolean(App.Global.TE1);
        E2.IsEnabled = Convert.ToBoolean(App.Global.TE2);
        E3.IsEnabled = Convert.ToBoolean(App.Global.TE3);
        E4.IsEnabled = Convert.ToBoolean(App.Global.TE4);
        E5.IsEnabled = Convert.ToBoolean(App.Global.TE5);
        E6.IsEnabled = Convert.ToBoolean(App.Global.TE6);
        E7.IsEnabled = Convert.ToBoolean(App.Global.TE7);
        E8.IsEnabled = Convert.ToBoolean(App.Global.TE8);

        F1.IsEnabled = Convert.ToBoolean(App.Global.TF1);
        F2.IsEnabled = Convert.ToBoolean(App.Global.TF2);
        F3.IsEnabled = Convert.ToBoolean(App.Global.TF3);
        F4.IsEnabled = Convert.ToBoolean(App.Global.TF4);
        F5.IsEnabled = Convert.ToBoolean(App.Global.TF5);
        F6.IsEnabled = Convert.ToBoolean(App.Global.TF6);
        F7.IsEnabled = Convert.ToBoolean(App.Global.TF7);
        F8.IsEnabled = Convert.ToBoolean(App.Global.TF8);
        ContentArea.Visibility = Visibility.Visible;
    }
    private void ClickLook(object sender, RoutedEventArgs e)
    {
        m_window = new ShowName();
        m_window.Activate();
    }

    private Window m_window;
    private void ClickName(object sender, RoutedEventArgs e)
    {
        //Trace.WriteLine(((ToggleButton)sender).Name);
        bool m = (bool)((ToggleButton)sender).IsChecked;
        if (m == false)
        {
            //JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
            //jarr.Remove(item);
            namelist.Remove(((ToggleButton)sender).Name);
        }
        if (m == true)
        {
            namelist.Add(((ToggleButton)sender).Name);
        }
    }    
    
    private async void ClickSave(object sender, RoutedEventArgs e)
    {
        string t = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ffff");
        string liststr = String.Join(",", namelist);
        string classname = "92";
        string ret = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/writename?class=" + classname + "&time=" + t + "&names=" + liststr);
        var cd = new ContentDialog
        {
            Title = "保存所记内容",
            Content = ret,
            PrimaryButtonText = "Ok",
            DefaultButton = ContentDialogButton.Primary
        };
        cd.XamlRoot = this.Content.XamlRoot;
        var result = await cd.ShowAsync();
    }
}
