using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白7Page : Page
{
    public 空白7ViewModel ViewModel
    {
        get;
    }

    public 空白7Page()
    {
        ViewModel = App.GetService<空白7ViewModel>();
        InitializeComponent();
    }
}
