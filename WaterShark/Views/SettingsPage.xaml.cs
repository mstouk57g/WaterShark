using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using WaterShark.Helpers;
using WaterShark.ViewModels;
using static WaterShark.App;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WaterShark.Core.Helpers;
using System.Net.Http.Json;
using System.Text;

namespace WaterShark.Views;

// TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel
    {
        get;
    }
    string path = "C:/WaterShark/services.json";
    public SettingsPage()
    {
        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();
        string lists = Global.classws;
        lists = lists.Substring(0, lists.Length - 2);
        lists = lists.Substring(1);
        String[] sArray = lists.Split(',');
        List<string> list = new List<string>(sArray);
        SetterClass.ItemsSource = list;
        string jsonStr = File.ReadAllText(path);
        JObject objs = JObject.Parse(jsonStr);
        string contc = objs["class"].ToString();
        SetterClass.SelectedItem = '"' + contc + '"';
    }
    
    private void classseter(object sender, SelectionChangedEventArgs e)
    {
        string Names = e.AddedItems[0].ToString();
        Names = Names.Substring(0, Names.Length - 1);
        Names = Names.Substring(1);
        string jsonStr = File.ReadAllText(path);
        JObject objs = JObject.Parse(jsonStr);
        objs["class"] = Names;
        File.WriteAllText(path, objs.ToString(), Encoding.UTF8);
        GettingScr.nm();
    }
}
