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
    public static string HttpWebRequest_Get(string url)
    {
        //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
        Encoding encoding = Encoding.UTF8;

        //构造一个Web请求的对象
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.Accept = "text/html, application/xhtml+xml, */*";
        request.ContentType = "application/json";

        //获取web请求的响应的内容
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
        {
            return reader.ReadToEnd();
        }
    }
    public 大课间写名字Page()
    {
        ViewModel = App.GetService<大课间写名字ViewModel>();
        InitializeComponent();
        A8.IsEnabled = false;
        E1.IsEnabled = false;
        E2.IsEnabled = false;
        F1.IsEnabled = false;
        F2.IsEnabled = false;
        F6.IsEnabled = false;
        F7.IsEnabled = false;
        F8.IsEnabled = false;
        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
        {
            JsonTextReader reader = new JsonTextReader(file);

            JObject o = (JObject)JToken.ReadFrom(reader);
            string a = o["names"].ToString();
            JArray b = JArray.Parse(a);
            string c = b[0]["name"].ToString();
            string d = b[0]["enable"].ToString();
            A1.Content = c;
            if(d == "true")
            {
                A1.IsEnabled = true;
            }
            if (d == "false")
            {
                A1.IsEnabled = false;
            }
            c = b[1]["name"].ToString();
            A2.Content = c;
            c = HttpWebRequest_Get("http://localhost:5000/toggle?value=2&key=name");
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
            d = b[0]["enable"].ToString();
            A8.Content = c;
            if (d == "true")
            {
                A8.IsEnabled = true;
            }
            if (d == "false")
            {
                A8.IsEnabled = false;
            }
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
