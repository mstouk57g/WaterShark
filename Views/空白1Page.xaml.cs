using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白1Page : Page
{
    public 空白1ViewModel ViewModel
    {
        get;
    }

    public 空白1Page()
    {
        ViewModel = App.GetService<空白1ViewModel>();
        InitializeComponent();
    }
}
