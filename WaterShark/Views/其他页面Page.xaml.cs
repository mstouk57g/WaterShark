using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 其他页面Page : Page
{
    public 其他页面ViewModel ViewModel
    {
        get;
    }

    public 其他页面Page()
    {
        ViewModel = App.GetService<其他页面ViewModel>();
        InitializeComponent();
    }
}
