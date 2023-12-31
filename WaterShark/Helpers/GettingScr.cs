using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WaterShark.App;


namespace WaterShark.Helpers
{
    internal class GettingScr
    {
        public static void nm()
        {
            Thread threadA1 = new Thread(() => { Global.A1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=0&key=name"); });
            Thread threadA2 = new Thread(() => { Global.A2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=1&key=name"); });
            Thread threadA3 = new Thread(() => { Global.A3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=2&key=name"); });
            Thread threadA4 = new Thread(() => { Global.A4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=3&key=name"); });
            Thread threadA5 = new Thread(() => { Global.A5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=4&key=name"); });
            Thread threadA6 = new Thread(() => { Global.A6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=5&key=name"); });
            Thread threadA7 = new Thread(() => { Global.A7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=6&key=name"); });
            Thread threadA8 = new Thread(() => { Global.A8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=7&key=name"); });

            Thread threadB1 = new Thread(() => { Global.B1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=8&key=name"); });
            Thread threadB2 = new Thread(() => { Global.B2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=9&key=name"); });
            Thread threadB3 = new Thread(() => { Global.B3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=10&key=name"); });
            Thread threadB4 = new Thread(() => { Global.B4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=11&key=name"); });
            Thread threadB5 = new Thread(() => { Global.B5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=12&key=name"); });
            Thread threadB6 = new Thread(() => { Global.B6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=13&key=name"); });
            Thread threadB7 = new Thread(() => { Global.B7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=14&key=name"); });
            Thread threadB8 = new Thread(() => { Global.B8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=15&key=name"); });

            Thread threadC1 = new Thread(() => { Global.C1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=16&key=name"); });
            Thread threadC2 = new Thread(() => { Global.C2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=17&key=name"); });
            Thread threadC3 = new Thread(() => { Global.C3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=18&key=name"); });
            Thread threadC4 = new Thread(() => { Global.C4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=19&key=name"); });
            Thread threadC5 = new Thread(() => { Global.C5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=20&key=name"); });
            Thread threadC6 = new Thread(() => { Global.C6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=21&key=name"); });
            Thread threadC7 = new Thread(() => { Global.C7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=22&key=name"); });
            Thread threadC8 = new Thread(() => { Global.C8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=23&key=name"); });

            Thread threadD1 = new Thread(() => { Global.D1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=24&key=name"); });
            Thread threadD2 = new Thread(() => { Global.D2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=25&key=name"); });
            Thread threadD3 = new Thread(() => { Global.D3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=26&key=name"); });
            Thread threadD4 = new Thread(() => { Global.D4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=27&key=name"); });
            Thread threadD5 = new Thread(() => { Global.D5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=28&key=name"); });
            Thread threadD6 = new Thread(() => { Global.D6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=29&key=name"); });
            Thread threadD7 = new Thread(() => { Global.D7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=30&key=name"); });
            Thread threadD8 = new Thread(() => { Global.D8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=31&key=name"); });

            Thread threadE1 = new Thread(() => { Global.E1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=32&key=name"); });
            Thread threadE2 = new Thread(() => { Global.E2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=33&key=name"); });
            Thread threadE3 = new Thread(() => { Global.E3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=34&key=name"); });
            Thread threadE4 = new Thread(() => { Global.E4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=35&key=name"); });
            Thread threadE5 = new Thread(() => { Global.E5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=36&key=name"); });
            Thread threadE6 = new Thread(() => { Global.E6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=37&key=name"); });
            Thread threadE7 = new Thread(() => { Global.E7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=38&key=name"); });
            Thread threadE8 = new Thread(() => { Global.E8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=39&key=name"); });

            Thread threadF1 = new Thread(() => { Global.F1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=40&key=name"); });
            Thread threadF2 = new Thread(() => { Global.F2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=41&key=name"); });
            Thread threadF3 = new Thread(() => { Global.F3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=42&key=name"); });
            Thread threadF4 = new Thread(() => { Global.F4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=43&key=name"); });
            Thread threadF5 = new Thread(() => { Global.F5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=44&key=name"); });
            Thread threadF6 = new Thread(() => { Global.F6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=45&key=name"); });
            Thread threadF7 = new Thread(() => { Global.F7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=46&key=name"); });
            Thread threadF8 = new Thread(() => { Global.F8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=47&key=name"); });

            threadA1.Start();
            threadA2.Start();
            threadA3.Start();
            threadA4.Start();
            threadA5.Start();
            threadA6.Start();
            threadA7.Start();
            threadA8.Start();

            threadB1.Start();
            threadB2.Start();
            threadB3.Start();
            threadB4.Start();
            threadB5.Start();
            threadB6.Start();
            threadB7.Start();
            threadB8.Start();

            threadC1.Start();
            threadC2.Start();
            threadC3.Start();
            threadC4.Start();
            threadC5.Start();
            threadC6.Start();
            threadC7.Start();
            threadC8.Start();

            threadD1.Start();
            threadD2.Start();
            threadD3.Start();
            threadD4.Start();
            threadD5.Start();
            threadD6.Start();
            threadD7.Start();
            threadD8.Start();

            threadE1.Start();
            threadE2.Start();
            threadE3.Start();
            threadE4.Start();
            threadE5.Start();
            threadE6.Start();
            threadE7.Start();
            threadE8.Start();

            threadF1.Start();
            threadF2.Start();
            threadF3.Start();
            threadF4.Start();
            threadF5.Start();
            threadF6.Start();
            threadF7.Start();
            threadF8.Start();
        }
    }
}
