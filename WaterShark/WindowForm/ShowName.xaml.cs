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
            ExtendsContentIntoTitleBar = true;
            AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
            //NameJson.Items.
            Title = "�����鿴";
            //string path = @"C:\Test\Debug1\";
            //var files = Directory.GetFiles(path, "*.json");
            //foreach (var file in files)
            //    NameJson.Items.Add(file);

            string classname = App.Global.classws;
            string lists = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/writenamelists?classes=" + classname);
            // = lists.Substring(0, lists.Length - 1);
            lists = lists.Substring(0, lists.Length - 2);
            lists = lists.Substring(1);
            String[] sArray = lists.Split(',');
            List<string> list = new List<string>(sArray);
            NameJson.ItemsSource = list;
        }
        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string classname = App.Global.classws;
            string Names = e.AddedItems[0].ToString();
            string lists = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/writenames?classes=" + classname + "&time=" + Names);
            Homo1145.Text = lists;
        }
    }
}
