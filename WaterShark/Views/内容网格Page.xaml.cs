using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 内容网格Page : Page
{
    public 内容网格ViewModel ViewModel
    {
        get;
    }

    public 内容网格Page()
    {
        ViewModel = App.GetService<内容网格ViewModel>();
        InitializeComponent();
    }
}
