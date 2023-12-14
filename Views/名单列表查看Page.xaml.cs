using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

using WaterShark.ViewModels;

namespace WaterShark.Views;

public sealed partial class 名单列表查看Page : Page
{
    public 名单列表查看ViewModel ViewModel
    {
        get;
    }

    public 名单列表查看Page()
    {
        ViewModel = App.GetService<名单列表查看ViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
