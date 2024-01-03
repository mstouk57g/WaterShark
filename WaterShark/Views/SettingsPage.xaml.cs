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
using Windows.Storage;

namespace WaterShark.Views;

// TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel
    {
        get;
    }
    
    public SettingsPage()
    {
        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();
        string lists = Global.classks;
        lists = lists.Substring(0, lists.Length - 2);
        lists = lists.Substring(1);
        String[] sArray = lists.Split(',');
        List<string> list = new List<string>(sArray);
        SetterClass.ItemsSource = list;
        ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        String contc = localSettings.Values["class"] as string;
        SetterClass.SelectedItem = '"' + contc + '"';
    }
    
    private void classseter(object sender, SelectionChangedEventArgs e)
    {
        ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        string Names = e.AddedItems[0].ToString();
        Names = Names.Substring(0, Names.Length - 1);
        Names = Names.Substring(1);
        localSettings.Values["class"] = Names;
        GettingScr.nm();
    }
}
