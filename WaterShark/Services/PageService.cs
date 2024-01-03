using CommunityToolkit.Mvvm.ComponentModel;

using Microsoft.UI.Xaml.Controls;

using WaterShark.Contracts.Services;
using WaterShark.ViewModels;
using WaterShark.Views;

namespace WaterShark.Services;

public class PageService : IPageService
{
    private readonly Dictionary<string, Type> _pages = new();

    public PageService()
    {
        Configure<主页ViewModel, 主页Page>();
        Configure<大课间写名字ViewModel, 大课间写名字Page>();
        Configure<英语老师专用抽ViewModel, 英语老师专用抽Page>();
        Configure<晚自习已经自闭ViewModel, 晚自习已经自闭Page>();
        Configure<其他页面ViewModel, 其他页面Page>();
        Configure<Web视图ViewModel, Web视图Page>();
        Configure<列表详细信息ViewModel, 列表详细信息Page>();
        Configure<内容网格ViewModel, 内容网格Page>();
        Configure<内容网格DetailViewModel, 内容网格DetailPage>();
        Configure<内容网格1ViewModel, 内容网格1Page>();
        Configure<SettingsViewModel, SettingsPage>();
        Configure<名单列表查看ViewModel, 名单列表查看Page>();
    }

    public Type GetPageType(string key)
    {
        Type? pageType;
        lock (_pages)
        {
            if (!_pages.TryGetValue(key, out pageType))
            {
                throw new ArgumentException($"Page not found: {key}. Did you forget to call PageService.Configure?");
            }
        }

        return pageType;
    }

    private void Configure<VM, V>()
        where VM : ObservableObject
        where V : Page
    {
        lock (_pages)
        {
            var key = typeof(VM).FullName!;
            if (_pages.ContainsKey(key))
            {
                throw new ArgumentException($"The key {key} is already configured in PageService");
            }

            var type = typeof(V);
            if (_pages.ContainsValue(type))
            {
                throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
            }

            _pages.Add(key, type);
        }
    }
}
