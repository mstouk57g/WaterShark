using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 主页Page : Page
{
    public 主页ViewModel ViewModel
    {
        get;
    }

    public 主页Page()
    {
        ViewModel = App.GetService<主页ViewModel>();
        InitializeComponent();
    }
}
