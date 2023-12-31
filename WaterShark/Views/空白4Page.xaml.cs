using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白4Page : Page
{
    public 空白4ViewModel ViewModel
    {
        get;
    }

    public 空白4Page()
    {
        ViewModel = App.GetService<空白4ViewModel>();
        InitializeComponent();
    }
}
