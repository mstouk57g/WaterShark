using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白Page : Page
{
    public 空白ViewModel ViewModel
    {
        get;
    }

    public 空白Page()
    {
        ViewModel = App.GetService<空白ViewModel>();
        InitializeComponent();
    }
}
