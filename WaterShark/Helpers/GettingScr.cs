using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WaterShark.App;


namespace WaterShark.Helpers
{
    internal class GettingScr
    {
        public static void GettingPositionA()
        {
            Global.A1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=0&key=name");
            Global.A2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=1&key=name");
            Global.A3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=2&key=name");
            Global.A4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=3&key=name");
            Global.A5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=4&key=name");
            Global.A6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=5&key=name");
            Global.A7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=6&key=name");
            Global.A8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=7&key=name");
        }
        public static void GettingPositionB()
        {
            Global.B1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=8&key=name");
            Global.B2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=9&key=name");
            Global.B3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=10&key=name");
            Global.B4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=11&key=name");
            Global.B5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=12&key=name");
            Global.B6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=13&key=name");
            Global.B7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=14&key=name");
            Global.B8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=15&key=name");
        }
        public static void GettingPositionC()
        {
            Global.C1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=16&key=name");
            Global.C2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=17&key=name");
            Global.C3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=18&key=name");
            Global.C4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=19&key=name");
            Global.C5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=20&key=name");
            Global.C6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=21&key=name");
            Global.C7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=22&key=name");
            Global.C8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=23&key=name");
        }
        public static void GettingPositionD()
        {
            Global.D1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=24&key=name");
            Global.D2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=25&key=name");
            Global.D3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=26&key=name");
            Global.D4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=27&key=name");
            Global.D5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=28&key=name");
            Global.D6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=29&key=name");
            Global.D7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=30&key=name");
            Global.D8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=31&key=name");
        }
        public static void GettingPositionE()
        {
            Global.E1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=32&key=name");
            Global.E2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=33&key=name");
            Global.E3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=34&key=name");
            Global.E4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=35&key=name");
            Global.E5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=36&key=name");
            Global.E6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=37&key=name");
            Global.E7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=38&key=name");
            Global.E8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=39&key=name");
        }
        public static void GettingPositionF()
        {
            Global.F1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=40&key=name");
            Global.F2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=41&key=name");
            Global.F3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=42&key=name");
            Global.F4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=43&key=name");
            Global.F5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=44&key=name");
            Global.F6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=45&key=name");
            Global.F7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=46&key=name");
            Global.F8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=47&key=name");
        }
    }
}
