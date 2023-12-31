using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白9Page : Page
{
    public 空白9ViewModel ViewModel
    {
        get;
    }

    public 空白9Page()
    {
        ViewModel = App.GetService<空白9ViewModel>();
        InitializeComponent();
    }
}
