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
        //loading.Visibility = Visibility.Visible;
        
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
            //jarr.Add(c);
            namelist.Add(((ToggleButton)sender).Name);
        }
    }    
    
    private async void ClickSave(object sender, RoutedEventArgs e)
    {
        string t = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ffff");
        //string d = @"C:\Test\Debug1\" + t + ".json";
        //File.Create(d).Close();
        //JObject jobj = new JObject();
        //jobj["id"] = jarr;

        //string jsonjson = JsonConvert.SerializeObject(jobj, Formatting.Indented);
        //File.WriteAllText(d, jsonjson);

        //string liststr = namelist.ToString();
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
