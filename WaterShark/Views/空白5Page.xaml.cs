using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白5Page : Page
{
    public 空白5ViewModel ViewModel
    {
        get;
    }

    public 空白5Page()
    {
        ViewModel = App.GetService<空白5ViewModel>();
        InitializeComponent();
    }
}
