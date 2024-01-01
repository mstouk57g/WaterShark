using Microsoft.UI.Xaml.Controls;
using WaterShark.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls.Primitives;
namespace WaterShark.Views;

public sealed partial class 英语老师专用抽Page : Page
{
    public 英语老师专用抽ViewModel ViewModel
    {
        get;
    }

    public 英语老师专用抽Page()
    {
        this.InitializeComponent();
        ViewModel = App.GetService<英语老师专用抽ViewModel>();
        string jsonfile = "C:/Test/test.json";
        JArray jarr = new JArray();
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
    }
    private void clickboom(object sender, RoutedEventArgs e)
    {
        Random ran = new Random();
        int n = ran.Next(0, 47);
        switch (n)
        {
            case 0:
                A1.IsChecked = true;
                break;
            case 1:
                A2.IsChecked = true;
                break;
            case 2:
                A3.IsChecked = true;
                break;
            case 3:
                A4.IsChecked = true;
                break;
            case 4:
                A5.IsChecked = true;
                break;
            case 5:
                A6.IsChecked = true;
                break;
            case 6:
                A7.IsChecked = true;
                break;
            case 7:
                A8.IsChecked = true;
                break;
            case 8:
                B1.IsChecked = true;
                break;
            case 9:
                B2.IsChecked = true;
                break;
            case 10:
                B3.IsChecked = true;
                break;
            case 11:
                B4.IsChecked = true;
                break;
            case 12:
                B5.IsChecked = true;
                break;
            case 13:
                B6.IsChecked = true;
                break;
            case 14:
                B7.IsChecked = true;
                break;
            case 15:
                B8.IsChecked = true;
                break;
            case 16:
                C1.IsChecked = true;
                break;
            case 17:
                C2.IsChecked = true;
                break;
            case 18:
                C3.IsChecked = true;
                break;
            case 19:
                C4.IsChecked = true;
                break;
            case 20:
                C5.IsChecked = true;
                break;
            case 21:
                C6.IsChecked = true;
                break;
            case 22:
                C7.IsChecked = true;
                break;
            case 23:
                C8.IsChecked = true;
                break;
            case 24:
                D1.IsChecked = true;
                break;
            case 25:
                D2.IsChecked = true;
                break;
            case 26:
                D3.IsChecked = true;
                break;
            case 27:
                D4.IsChecked = true;
                break;
            case 28:
                D5.IsChecked = true;
                break;
            case 29:
                D6.IsChecked = true;
                break;
            case 30:
                D7.IsChecked = true;
                break;
            case 31:
                D8.IsChecked = true;
                break;
            case 32:
                E1.IsChecked = true;
                break;
            case 33:
                E2.IsChecked = true;
                break;
            case 34:
                E3.IsChecked = true;
                break;
            case 35:
                E4.IsChecked = true;
                break;
            case 36:
                E5.IsChecked = true;
                break;
            case 37:
                E6.IsChecked = true;
                break;
            case 38:
                E7.IsChecked = true;
                break;
            case 39:
                E8.IsChecked = true;
                break;
            case 40:
                F1.IsChecked = true;
                break;
            case 41:
                F2.IsChecked = true;
                break;
            case 42:
                F3.IsChecked = true;
                break;
            case 43:
                F4.IsChecked = true;
                break;
            case 44:
                F5.IsChecked = true;
                break;
            case 45:
                F6.IsChecked = true;
                break;
            case 46:
                F7.IsChecked = true;
                break;
            case 47:
                F8.IsChecked = true;
                break;
        }
        
    }
    private void clickZERO(object sender, RoutedEventArgs e)
    {
        A1.IsChecked = false;
        A2.IsChecked = false;
        A3.IsChecked = false;
        A4.IsChecked = false;
        A5.IsChecked = false;
        A6.IsChecked = false;
        A7.IsChecked = false;
        A8.IsChecked = false;
        B1.IsChecked = false;
        B2.IsChecked = false;
        B3.IsChecked = false;
        B4.IsChecked = false;
        B5.IsChecked = false;
        B6.IsChecked = false;
        B7.IsChecked = false;
        B8.IsChecked = false;
        C1.IsChecked = false;
        C2.IsChecked = false;
        C3.IsChecked = false;
        C4.IsChecked = false;
        C5.IsChecked = false;
        C6.IsChecked = false;
        C7.IsChecked = false;
        C8.IsChecked = false;
        D1.IsChecked = false;
        D2.IsChecked = false;
        D3.IsChecked = false;
        D4.IsChecked = false;
        D5.IsChecked = false;
        D6.IsChecked = false;
        D7.IsChecked = false;
        D8.IsChecked = false;
        E1.IsChecked = false;
        E2.IsChecked = false;
        E3.IsChecked = false;
        E4.IsChecked = false;
        E5.IsChecked = false;
        E6.IsChecked = false;
        E7.IsChecked = false;
        E8.IsChecked = false;
        F1.IsChecked = false;
        F2.IsChecked = false;
        F3.IsChecked = false;
        F4.IsChecked = false;
        F5.IsChecked = false;
        F6.IsChecked = false;
        F7.IsChecked = false;
        F8.IsChecked = false;
    }
}
