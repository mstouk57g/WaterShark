using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class oobePage : Page
{
    public oobeViewModel ViewModel
    {
        get;
    }

    public oobePage()
    {
        ViewModel = App.GetService<oobeViewModel>();
        InitializeComponent();
    }
}
