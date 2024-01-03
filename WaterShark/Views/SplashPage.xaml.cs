using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class SplashPage : Page
{
    public SplashViewModel ViewModel
    {
        get;
    }

    public SplashPage()
    {
        ViewModel = App.GetService<SplashViewModel>();
        InitializeComponent();
    }
}
