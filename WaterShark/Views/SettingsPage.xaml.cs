using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using WaterShark.Helpers;
using WaterShark.ViewModels;
using static WaterShark.App;

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
        string lists = Global.classws;
        lists = lists.Substring(0, lists.Length - 2);
        Trace.WriteLine(lists);
        lists = lists.Substring(1);
        Trace.WriteLine(lists);
        String[] sArray = lists.Split(',');
        List<string> list = new List<string>(sArray);
        Trace.WriteLine(sArray);
        SetterClass.ItemsSource = list;
    }
    
    private void classseter(object sender, SelectionChangedEventArgs e)
    {
        string Names = e.AddedItems[0].ToString();
    }
}
