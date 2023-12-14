using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白1Page : Page
{
    private int num = 2400;
    private System.Windows.Threading.DispatcherTimer dispatcherTimer = null;
    public 空白1ViewModel ViewModel
    {
        get;
    }

    public 空白1Page()
    {
        ViewModel = App.GetService<空白1ViewModel>();
        InitializeComponent();
        display_number();

        dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        dispatcherTimer.Start();

    }
    private void dispatcherTimer_Tick(object sender, EventArgs e)//计时执行的程序
    {
        num -= 1;
        if (num == 0)
        {
            dispatcherTimer.Stop();
            return;
        }

        display_number();
    }

    private void display_number()
    {
        // display num
        num1.Text = Convert.ToString((num / 60) / 10);
        num2.Text = Convert.ToString((num / 60) % 10);
        num4.Text = Convert.ToString((num % 60) / 10);
        num5.Text = Convert.ToString((num % 60) % 10);
    }
 

}
