using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 空白6Page : Page
{
    public 空白6ViewModel ViewModel
    {
        get;
    }

    public 空白6Page()
    {
        ViewModel = App.GetService<空白6ViewModel>();
        InitializeComponent();
    }
}
