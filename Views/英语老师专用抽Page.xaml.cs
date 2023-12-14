using Microsoft.UI.Xaml.Controls;
using WaterShark.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.UI.Xaml;
namespace WaterShark.Views;

public sealed partial class 英语老师专用抽Page : Page
{
    public 英语老师专用抽ViewModel ViewModel
    {
        get;
    }

    public 英语老师专用抽Page()
    {
        ViewModel = App.GetService<英语老师专用抽ViewModel>();
        string jsonfile = "C:/Test/test.json";
        JArray jarr = new JArray();
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            InitializeComponent();
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[0]["name"].ToString();
            A1.Content = c;
            c = b[1]["name"].ToString();
            A2.Content = c;
            c = b[2]["name"].ToString();
            A3.Content = c;
            c = b[3]["name"].ToString();
            A4.Content = c;
            c = b[4]["name"].ToString();
            A5.Content = c;
            c = b[5]["name"].ToString();
            A6.Content = c;
            c = b[6]["name"].ToString();
            A7.Content = c;
            c = b[7]["name"].ToString();
            A8.Content = c;
            c = b[8]["name"].ToString();
            B1.Content = c;
            c = b[9]["name"].ToString();
            B2.Content = c;
            c = b[10]["name"].ToString();
            B3.Content = c;
            c = b[11]["name"].ToString();
            B4.Content = c;
            c = b[12]["name"].ToString();
            B5.Content = c;
            c = b[13]["name"].ToString();
            B6.Content = c;
            c = b[14]["name"].ToString();
            B7.Content = c;
            c = b[15]["name"].ToString();
            B8.Content = c;
            c = b[16]["name"].ToString();
            C1.Content = c;
            c = b[17]["name"].ToString();
            C2.Content = c;
            c = b[18]["name"].ToString();
            C3.Content = c;
            c = b[19]["name"].ToString();
            C4.Content = c;
            c = b[20]["name"].ToString();
            C5.Content = c;
            c = b[21]["name"].ToString();
            C6.Content = c;
            c = b[22]["name"].ToString();
            C7.Content = c;
            c = b[23]["name"].ToString();
            C8.Content = c;
            c = b[24]["name"].ToString();
            D1.Content = c;
            c = b[25]["name"].ToString();
            D2.Content = c;
            c = b[26]["name"].ToString();
            D3.Content = c;
            c = b[27]["name"].ToString();
            D4.Content = c;
            c = b[28]["name"].ToString();
            D5.Content = c;
            c = b[29]["name"].ToString();
            D6.Content = c;
            c = b[30]["name"].ToString();
            D7.Content = c;
            c = b[31]["name"].ToString();
            D8.Content = c;
            c = b[32]["name"].ToString();
            E1.Content = c;
            c = b[33]["name"].ToString();
            E2.Content = c;
            c = b[34]["name"].ToString();
            E3.Content = c;
            c = b[35]["name"].ToString();
            E4.Content = c;
            c = b[36]["name"].ToString();
            E5.Content = c;
            c = b[37]["name"].ToString();
            E6.Content = c;
            c = b[38]["name"].ToString();
            E7.Content = c;
            c = b[39]["name"].ToString();
            E8.Content = c;
            c = b[40]["name"].ToString();
            F1.Content = c;
            c = b[41]["name"].ToString();
            F2.Content = c;
            c = b[42]["name"].ToString();
            F3.Content = c;
            c = b[43]["name"].ToString();
            F4.Content = c;
            c = b[44]["name"].ToString();
            F5.Content = c;
            c = b[45]["name"].ToString();
            F6.Content = c;
            c = b[46]["name"].ToString();
            F7.Content = c;
            c = b[47]["name"].ToString();
            F8.Content = c;
            file.Close();
        }
        A8.IsEnabled = false;
        E1.IsEnabled = false;
        E2.IsEnabled = false;
        F1.IsEnabled = false;
        F2.IsEnabled = false;
        F6.IsEnabled = false;
        F7.IsEnabled = false;
        F8.IsEnabled = false;
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
