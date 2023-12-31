using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白8Page : Page
{
    public 空白8ViewModel ViewModel
    {
        get;
    }

    public 空白8Page()
    {
        ViewModel = App.GetService<空白8ViewModel>();
        InitializeComponent();
    }
}
