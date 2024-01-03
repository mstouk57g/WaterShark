using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using static WaterShark.App;


namespace WaterShark.Helpers
{
    internal class GettingScr
    {
        public static void nm()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String c = localSettings.Values["class"] as string;
            App.Global.classws = c;

            Thread threadA1 = new Thread(() => { Global.A1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=0&key=name&class=" + c); });
            Thread threadA2 = new Thread(() => { Global.A2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=1&key=name&class=" + c); });
            Thread threadA3 = new Thread(() => { Global.A3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=2&key=name&class=" + c); });
            Thread threadA4 = new Thread(() => { Global.A4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=3&key=name&class=" + c); });
            Thread threadA5 = new Thread(() => { Global.A5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=4&key=name&class=" + c); });
            Thread threadA6 = new Thread(() => { Global.A6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=5&key=name&class=" + c); });
            Thread threadA7 = new Thread(() => { Global.A7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=6&key=name&class=" + c); });
            Thread threadA8 = new Thread(() => { Global.A8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=7&key=name&class=" + c); });

            Thread threadB1 = new Thread(() => { Global.B1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=8&key=name&class=" + c); });
            Thread threadB2 = new Thread(() => { Global.B2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=9&key=name&class=" + c); });
            Thread threadB3 = new Thread(() => { Global.B3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=10&key=name&class=" + c); });
            Thread threadB4 = new Thread(() => { Global.B4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=11&key=name&class=" + c); });
            Thread threadB5 = new Thread(() => { Global.B5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=12&key=name&class=" + c); });
            Thread threadB6 = new Thread(() => { Global.B6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=13&key=name&class=" + c); });
            Thread threadB7 = new Thread(() => { Global.B7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=14&key=name&class=" + c); });
            Thread threadB8 = new Thread(() => { Global.B8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=15&key=name&class=" + c); });

            Thread threadC1 = new Thread(() => { Global.C1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=16&key=name&class=" + c); });
            Thread threadC2 = new Thread(() => { Global.C2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=17&key=name&class=" + c); });
            Thread threadC3 = new Thread(() => { Global.C3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=18&key=name&class=" + c); });
            Thread threadC4 = new Thread(() => { Global.C4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=19&key=name&class=" + c); });
            Thread threadC5 = new Thread(() => { Global.C5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=20&key=name&class=" + c); });
            Thread threadC6 = new Thread(() => { Global.C6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=21&key=name&class=" + c); });
            Thread threadC7 = new Thread(() => { Global.C7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=22&key=name&class=" + c); });
            Thread threadC8 = new Thread(() => { Global.C8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=23&key=name&class=" + c); });

            Thread threadD1 = new Thread(() => { Global.D1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=24&key=name&class=" + c); });
            Thread threadD2 = new Thread(() => { Global.D2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=25&key=name&class=" + c); });
            Thread threadD3 = new Thread(() => { Global.D3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=26&key=name&class=" + c); });
            Thread threadD4 = new Thread(() => { Global.D4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=27&key=name&class=" + c); });
            Thread threadD5 = new Thread(() => { Global.D5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=28&key=name&class=" + c); });
            Thread threadD6 = new Thread(() => { Global.D6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=29&key=name&class=" + c); });
            Thread threadD7 = new Thread(() => { Global.D7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=30&key=name&class=" + c); });
            Thread threadD8 = new Thread(() => { Global.D8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=31&key=name&class=" + c); });

            Thread threadE1 = new Thread(() => { Global.E1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=32&key=name&class=" + c); });
            Thread threadE2 = new Thread(() => { Global.E2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=33&key=name&class=" + c); });
            Thread threadE3 = new Thread(() => { Global.E3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=34&key=name&class=" + c); });
            Thread threadE4 = new Thread(() => { Global.E4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=35&key=name&class=" + c); });
            Thread threadE5 = new Thread(() => { Global.E5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=36&key=name&class=" + c); });
            Thread threadE6 = new Thread(() => { Global.E6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=37&key=name&class=" + c); });
            Thread threadE7 = new Thread(() => { Global.E7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=38&key=name&class=" + c); });
            Thread threadE8 = new Thread(() => { Global.E8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=39&key=name&class=" + c); });

            Thread threadF1 = new Thread(() => { Global.F1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=40&key=name&class=" + c); });
            Thread threadF2 = new Thread(() => { Global.F2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=41&key=name&class=" + c); });
            Thread threadF3 = new Thread(() => { Global.F3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=42&key=name&class=" + c); });
            Thread threadF4 = new Thread(() => { Global.F4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=43&key=name&class=" + c); });
            Thread threadF5 = new Thread(() => { Global.F5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=44&key=name&class=" + c); });
            Thread threadF6 = new Thread(() => { Global.F6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=45&key=name&class=" + c); });
            Thread threadF7 = new Thread(() => { Global.F7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=46&key=name&class=" + c); });
            Thread threadF8 = new Thread(() => { Global.F8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=47&key=name&class=" + c); });

            Thread tfA1 = new Thread(() => { Global.TA1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A1"); });
            Thread tfA2 = new Thread(() => { Global.TA2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A2"); });
            Thread tfA3 = new Thread(() => { Global.TA3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A3"); });
            Thread tfA4 = new Thread(() => { Global.TA4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A4"); });
            Thread tfA5 = new Thread(() => { Global.TA5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A5"); });
            Thread tfA6 = new Thread(() => { Global.TA6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A6"); });
            Thread tfA7 = new Thread(() => { Global.TA7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A7"); });
            Thread tfA8 = new Thread(() => { Global.TA8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=A8"); });

            Thread tfB1 = new Thread(() => { Global.TB1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B1"); });
            Thread tfB2 = new Thread(() => { Global.TB2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B2"); });
            Thread tfB3 = new Thread(() => { Global.TB3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B3"); });
            Thread tfB4 = new Thread(() => { Global.TB4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B4"); });
            Thread tfB5 = new Thread(() => { Global.TB5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B5"); });
            Thread tfB6 = new Thread(() => { Global.TB6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B6"); });
            Thread tfB7 = new Thread(() => { Global.TB7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B7"); });
            Thread tfB8 = new Thread(() => { Global.TB8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=B8"); });

            Thread tfC1 = new Thread(() => { Global.TC1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C1"); });
            Thread tfC2 = new Thread(() => { Global.TC2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C2"); });
            Thread tfC3 = new Thread(() => { Global.TC3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C3"); });
            Thread tfC4 = new Thread(() => { Global.TC4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C4"); });
            Thread tfC5 = new Thread(() => { Global.TC5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C5"); });
            Thread tfC6 = new Thread(() => { Global.TC6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C6"); });
            Thread tfC7 = new Thread(() => { Global.TC7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C7"); });
            Thread tfC8 = new Thread(() => { Global.TC8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=C8"); });

            Thread tfD1 = new Thread(() => { Global.TD1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D1"); });
            Thread tfD2 = new Thread(() => { Global.TD2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D2"); });
            Thread tfD3 = new Thread(() => { Global.TD3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D3"); });
            Thread tfD4 = new Thread(() => { Global.TD4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D4"); });
            Thread tfD5 = new Thread(() => { Global.TD5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D5"); });
            Thread tfD6 = new Thread(() => { Global.TD6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D6"); });
            Thread tfD7 = new Thread(() => { Global.TD7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D7"); });
            Thread tfD8 = new Thread(() => { Global.TD8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=D8"); });

            Thread tfE1 = new Thread(() => { Global.TE1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E1"); });
            Thread tfE2 = new Thread(() => { Global.TE2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E2"); });
            Thread tfE3 = new Thread(() => { Global.TE3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E3"); });
            Thread tfE4 = new Thread(() => { Global.TE4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E4"); });
            Thread tfE5 = new Thread(() => { Global.TE5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E5"); });
            Thread tfE6 = new Thread(() => { Global.TE6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E6"); });
            Thread tfE7 = new Thread(() => { Global.TE7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E7"); });
            Thread tfE8 = new Thread(() => { Global.TE8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=E8"); });

            Thread tfF1 = new Thread(() => { Global.TF1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F1"); });
            Thread tfF2 = new Thread(() => { Global.TF2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F2"); });
            Thread tfF3 = new Thread(() => { Global.TF3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F3"); });
            Thread tfF4 = new Thread(() => { Global.TF4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F4"); });
            Thread tfF5 = new Thread(() => { Global.TF5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F5"); });
            Thread tfF6 = new Thread(() => { Global.TF6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F6"); });
            Thread tfF7 = new Thread(() => { Global.TF7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F7"); });
            Thread tfF8 = new Thread(() => { Global.TF8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/gettf?class=" + c + "&button=F8"); });

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

            tfA1.Start();
            tfA2.Start();
            tfA3.Start();
            tfA4.Start();
            tfA5.Start();
            tfA6.Start();
            tfA7.Start();
            tfA8.Start();

            tfB1.Start();
            tfB2.Start();
            tfB3.Start();
            tfB4.Start();
            tfB5.Start();
            tfB6.Start();
            tfB7.Start();
            tfB8.Start();

            tfC1.Start();
            tfC2.Start();
            tfC3.Start();
            tfC4.Start();
            tfC5.Start();
            tfC6.Start();
            tfC7.Start();
            tfC8.Start();

            tfD1.Start();
            tfD2.Start();
            tfD3.Start();
            tfD4.Start();
            tfD5.Start();
            tfD6.Start();
            tfD7.Start();
            tfD8.Start();

            tfE1.Start();
            tfE2.Start();
            tfE3.Start();
            tfE4.Start();
            tfE5.Start();
            tfE6.Start();
            tfE7.Start();
            tfE8.Start();

            tfF1.Start();
            tfF2.Start();
            tfF3.Start();
            tfF4.Start();
            tfF5.Start();
            tfF6.Start();
            tfF7.Start();
            tfF8.Start();
        }
        public static void getcl()
        {
            Thread threadwcnm = new Thread(() => { Global.classks = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/getclasses"); });
            threadwcnm.Start();
        }
    }
}
