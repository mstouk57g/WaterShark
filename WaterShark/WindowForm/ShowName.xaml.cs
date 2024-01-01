using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WaterShark.Helpers;
using System.Diagnostics;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WaterShark.WindowForm
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowName : Window
    {
        public ShowName()
        {
            this.InitializeComponent();
            AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
            //NameJson.Items.
            Title = "名单查看";
            //string path = @"C:\Test\Debug1\";
            //var files = Directory.GetFiles(path, "*.json");
            //foreach (var file in files)
            //    NameJson.Items.Add(file);

            string classname = "92";
            string lists = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/writenamelists?class=" + classname);
            Trace.WriteLine(lists);
        }
        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string colorName = e.AddedItems[0].ToString();
            using (System.IO.StreamReader file = System.IO.File.OpenText(colorName))
            {
                JsonTextReader reader = new JsonTextReader(file);
                JObject o = (JObject)JToken.ReadFrom(reader);
                if (o != null)
                {
                    string a = o["id"].ToString();
                    JArray b = JArray.Parse(a);
                    string c = b.ToString();
                    Homo1145.Text = c;
                }
                else
                {
                    Homo1145.Text = "没有人";
                }
            }
        }
    }
}
