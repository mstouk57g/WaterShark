using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using Newtonsoft.Json.Linq;
using WaterShark.ViewModels;
using Newtonsoft.Json;
using Windows.Media.AppBroadcasting;
using System.Net;
using System.Text;

namespace WaterShark.Views;

public sealed partial class 大课间写名字Page : Page
{
    
    string jsonfile = "C:/Test/test.json";
    JArray jarr = new JArray();
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
        loading.Visibility = Visibility.Collapsed;
        ContentArea.Visibility = Visibility.Visible;
    }
    private void ClickLook(object sender, RoutedEventArgs e)
    {
        m_window = new ShowName();
        m_window.Activate();
    }

    private Window m_window;
    private async void ClickA1(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[0]["name"].ToString();
            bool m = (bool)A1.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {

                jarr.Add(c);
            }
        }
    }
    private void ClickA2(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[1]["name"].ToString();
            bool m = (bool)A2.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickA3(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[2]["name"].ToString();
            bool m = (bool)A3.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickA4(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[3]["name"].ToString();
            bool m = (bool)A4.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickA5(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[4]["name"].ToString();
            bool m = (bool)A5.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickA6(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[5]["name"].ToString();
            bool m = (bool)A6.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickA7(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[6]["name"].ToString();
            bool m = (bool)A7.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickA8(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[7]["name"].ToString();
            bool m = (bool)A8.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB1(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[8]["name"].ToString();
            bool m = (bool)B1.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB2(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[9]["name"].ToString();
            bool m = (bool)B2.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB3(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[10]["name"].ToString();
            bool m = (bool)B3.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB4(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[11]["name"].ToString();
            bool m = (bool)B4.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB5(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[12]["name"].ToString();
            bool m = (bool)B5.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB6(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[13]["name"].ToString();
            bool m = (bool)B6.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB7(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[14]["name"].ToString();
            bool m = (bool)B7.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickB8(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[15]["name"].ToString();
            bool m = (bool)B8.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC1(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[16]["name"].ToString();
            bool m = (bool)C1.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC2(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[17]["name"].ToString();
            bool m = (bool)C2.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC3(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[18]["name"].ToString();
            bool m = (bool)C3.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC4(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[14]["name"].ToString();
            bool m = (bool)C4.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC5(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[15]["name"].ToString();
            bool m = (bool)C5.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC6(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[21]["name"].ToString();
            bool m = (bool)C6.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC7(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[22]["name"].ToString();
            bool m = (bool)C7.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickC8(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[23]["name"].ToString();
            bool m = (bool)C8.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD1(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[24]["name"].ToString();
            bool m = (bool)D1.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD2(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[25]["name"].ToString();
            bool m = (bool)D2.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD3(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[26]["name"].ToString();
            bool m = (bool)D3.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD4(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[27]["name"].ToString();
            bool m = (bool)D4.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD5(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[28]["name"].ToString();
            bool m = (bool)D5.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD6(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[29]["name"].ToString();
            bool m = (bool)D6.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD7(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[30]["name"].ToString();
            bool m = (bool)D7.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickD8(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[31]["name"].ToString();
            bool m = (bool)D8.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE1(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[32]["name"].ToString();
            bool m = (bool)E1.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE2(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[33]["name"].ToString();
            bool m = (bool)E2.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE3(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[34]["name"].ToString();
            bool m = (bool)E3.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE4(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[35]["name"].ToString();
            bool m = (bool)E4.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE5(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[36]["name"].ToString();
            bool m = (bool)E5.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE6(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[37]["name"].ToString();
            bool m = (bool)E6.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE7(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[38]["name"].ToString();
            bool m = (bool)E7.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickE8(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[39]["name"].ToString();
            bool m = (bool)E8.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF1(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[40]["name"].ToString();
            bool m = (bool)F1.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF2(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[41]["name"].ToString();
            bool m = (bool)F2.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF3(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[42]["name"].ToString();
            bool m = (bool)F3.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF4(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[43]["name"].ToString();
            bool m = (bool)F4.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF5(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[44]["name"].ToString();
            bool m = (bool)F5.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF6(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[45]["name"].ToString();
            bool m = (bool)F6.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF7(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[46]["name"].ToString();
            bool m = (bool)F7.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private void ClickF8(object sender, RoutedEventArgs e)
    {
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[47]["name"].ToString();
            bool m = (bool)F8.IsChecked;
            if (m == false)
            {
                JToken item = jarr.FirstOrDefault(arr => arr.Type == JTokenType.String && arr.Value<string>() == c);
                jarr.Remove(item);
            }
            if (m == true)
            {
                jarr.Add(c);
            }
        }
    }
    private async void ClickSave(object sender, RoutedEventArgs e)
    {
        string t = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ffff");
        string d = @"C:\Test\Debug1\" + t + ".json";
        File.Create(d).Close();
        JObject jobj = new JObject();
        jobj["id"] = jarr;

        string jsonjson = JsonConvert.SerializeObject(jobj, Formatting.Indented);
        File.WriteAllText(d, jsonjson);
        //string d = string.Empty;
        //string t = DateTime.Now.ToString();
        //JObject jobj = new JObject();
        //jobj[t] = jarr;
        //string jsonjson = JsonConvert.SerializeObject(jobj, Formatting.Indented);
        //using (System.IO.StreamReader file = System.IO.File.OpenText(jsonjsonjson))
        //{
        //    JsonTextReader reader = new JsonTextReader(file);
        //
        //    JObject o = (JObject)JToken.ReadFrom(reader);
        //    string a = o.ToString();
        ///    var obj = JsonConvert.DeserializeObject(a);
        //    foreach (var x in obj as JObject)
        //    {
        //        jobj[x.Key] = x.Value;
        //    }
        ///     d = JsonConvert.SerializeObject(jsonjson, Formatting.Indented);
        // }
        // File.WriteAllText(jsonjsonjson, d);
        var cd = new ContentDialog
        {
            Title = "保存所记内容",
            Content = "已保存至" + d + "数据文件",
            PrimaryButtonText = "Ok",
            DefaultButton = ContentDialogButton.Primary
        };
        cd.XamlRoot = this.Content.XamlRoot;
        var result = await cd.ShowAsync();


    }
}
