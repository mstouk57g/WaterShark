using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using WaterShark.Core.Models;

namespace WaterShark.Views;

public sealed partial class 名单列表查看DetailControl : UserControl
{
    public SampleOrder? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as SampleOrder;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(名单列表查看DetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public 名单列表查看DetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is 名单列表查看DetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
