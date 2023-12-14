using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using WaterShark.Core.Models;

namespace WaterShark.Views;

public sealed partial class 列表详细信息DetailControl : UserControl
{
    public SampleOrder? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as SampleOrder;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(列表详细信息DetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public 列表详细信息DetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is 列表详细信息DetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
