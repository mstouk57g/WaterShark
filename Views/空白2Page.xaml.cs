using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白2Page : Page
{
    public 空白2ViewModel ViewModel
    {
        get;
    }

    public 空白2Page()
    {
        ViewModel = App.GetService<空白2ViewModel>();
        InitializeComponent();
    }
}
