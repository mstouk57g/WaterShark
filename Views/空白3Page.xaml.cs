using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白3Page : Page
{
    public 空白3ViewModel ViewModel
    {
        get;
    }

    public 空白3Page()
    {
        ViewModel = App.GetService<空白3ViewModel>();
        InitializeComponent();
    }
}
