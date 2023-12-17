using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using System.Diagnostics;
using WaterShark.Activation;
using WaterShark.Contracts.Services;
using WaterShark.Core.Contracts.Services;
using WaterShark.Core.Services;
using WaterShark.Helpers;
using WaterShark.Models;
using WaterShark.Notifications;
using WaterShark.Services;
using WaterShark.ViewModels;
using WaterShark.Views;

namespace WaterShark;

// To learn more about WinUI 3, see https://docs.microsoft.com/windows/apps/winui/winui3/.
public partial class App : Application
{
    // The .NET Generic Host provides dependency injection, configuration, logging, and other services.
    // https://docs.microsoft.com/dotnet/core/extensions/generic-host
    // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
    // https://docs.microsoft.com/dotnet/core/extensions/configuration
    // https://docs.microsoft.com/dotnet/core/extensions/logging
    public IHost Host
    {
        get;
    }

    public static T GetService<T>()
        where T : class
    {
        if ((App.Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
        {
            throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.");
        }

        return service;
    }

    public static WindowEx MainWindow { get; } = new MainWindow();

    public static UIElement? AppTitlebar { get; set; }

    public App()
    {
        InitializeComponent();

        Host = Microsoft.Extensions.Hosting.Host.
        CreateDefaultBuilder().
        UseContentRoot(AppContext.BaseDirectory).
        ConfigureServices((context, services) =>
        {
            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Other Activation Handlers
            services.AddTransient<IActivationHandler, AppNotificationActivationHandler>();

            // Services
            services.AddSingleton<IAppNotificationService, AppNotificationService>();
            services.AddSingleton<ILocalSettingsService, LocalSettingsService>();
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddTransient<IWebViewService, WebViewService>();
            services.AddTransient<INavigationViewService, NavigationViewService>();

            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Core Services
            services.AddSingleton<ISampleDataService, SampleDataService>();
            services.AddSingleton<IFileService, FileService>();

            // Views and ViewModels
            services.AddTransient<名单列表查看ViewModel>();
            services.AddTransient<名单列表查看Page>();
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<SettingsPage>();
            services.AddTransient<内容网格1ViewModel>();
            services.AddTransient<内容网格1Page>();
            services.AddTransient<内容网格DetailViewModel>();
            services.AddTransient<内容网格DetailPage>();
            services.AddTransient<内容网格ViewModel>();
            services.AddTransient<内容网格Page>();
            services.AddTransient<列表详细信息ViewModel>();
            services.AddTransient<列表详细信息Page>();
            services.AddTransient<Web视图ViewModel>();
            services.AddTransient<Web视图Page>();
            services.AddTransient<其他页面ViewModel>();
            services.AddTransient<其他页面Page>();
            services.AddTransient<空白9ViewModel>();
            services.AddTransient<空白9Page>();
            services.AddTransient<空白8ViewModel>();
            services.AddTransient<空白8Page>();
            services.AddTransient<空白7ViewModel>();
            services.AddTransient<空白7Page>();
            services.AddTransient<空白5ViewModel>();
            services.AddTransient<空白5Page>();
            services.AddTransient<空白6ViewModel>();
            services.AddTransient<空白6Page>();
            services.AddTransient<空白4ViewModel>();
            services.AddTransient<空白4Page>();
            services.AddTransient<空白3ViewModel>();
            services.AddTransient<空白3Page>();
            services.AddTransient<空白2ViewModel>();
            services.AddTransient<空白2Page>();
            services.AddTransient<空白1ViewModel>();
            services.AddTransient<空白1Page>();
            services.AddTransient<空白ViewModel>();
            services.AddTransient<空白Page>();
            services.AddTransient<晚自习已经自闭ViewModel>();
            services.AddTransient<晚自习已经自闭Page>();
            services.AddTransient<英语老师专用抽ViewModel>();
            services.AddTransient<英语老师专用抽Page>();
            services.AddTransient<大课间写名字ViewModel>();
            services.AddTransient<大课间写名字Page>();
            services.AddTransient<主页ViewModel>();
            services.AddTransient<主页Page>();
            services.AddTransient<ShellPage>();
            services.AddTransient<ShellViewModel>();

            // Configuration
            services.Configure<LocalSettingsOptions>(context.Configuration.GetSection(nameof(LocalSettingsOptions)));
        }).
        Build();

        App.GetService<IAppNotificationService>().Initialize();

        UnhandledException += App_UnhandledException;
    }

    private void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
    {
        // TODO: Log and handle exceptions as appropriate.
        // https://docs.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.application.unhandledexception.
    }
    public static class Global
    {
        public static string A1;
        public static string A2;
        public static string A3;
        public static string A4;
        public static string A5;
        public static string A6;
        public static string A7;
        public static string A8;
        public static string B1;
        public static string B2;
        public static string B3;
        public static string B4;
        public static string B5;
        public static string B6;
        public static string B7;
        public static string B8;
        public static string C1;
        public static string C2;
        public static string C3;
        public static string C4;
        public static string C5;
        public static string C6;
        public static string C7;
        public static string C8;
        public static string D1;
        public static string D2;
        public static string D3;
        public static string D4;
        public static string D5;
        public static string D6;
        public static string D7;
        public static string D8;
        public static string E1;
        public static string E2;
        public static string E3;
        public static string E4;
        public static string E5;
        public static string E6;
        public static string E7;
        public static string E8;
        public static string F1;
        public static string F2;
        public static string F3;
        public static string F4;
        public static string F5;
        public static string F6;
        public static string F7;
        public static string F8;
    }
    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);
        //spalsh
        Process p = Process.Start("F:/WaterShark/Splash/bin/Debug/net8.0-windows/Splash.exe");

        //loading info
        Global.A1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=0&key=name");
        Global.A2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=1&key=name");
        Global.A3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=2&key=name");
        Global.A4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=3&key=name");
        Global.A5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=4&key=name");
        Global.A6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=5&key=name");
        Global.A7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=6&key=name");
        Global.A8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=7&key=name");
        Global.B1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=8&key=name");
        Global.B2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=9&key=name");
        Global.B3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=10&key=name");
        Global.B4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=11&key=name");
        Global.B5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=12&key=name");
        Global.B6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=13&key=name");
        Global.B7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=14&key=name");
        Global.B8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=15&key=name");
        Global.C1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=16&key=name");
        Global.C2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=17&key=name");
        Global.C3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=18&key=name");
        Global.C4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=19&key=name");
        Global.C5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=20&key=name");
        Global.C6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=21&key=name");
        Global.C7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=22&key=name");
        Global.C8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=23&key=name");
        Global.D1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=24&key=name");
        Global.D2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=25&key=name");
        Global.D3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=26&key=name");
        Global.D4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=27&key=name");
        Global.D5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=28&key=name");
        Global.D6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=29&key=name");
        Global.D7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=30&key=name");
        Global.D8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=31&key=name");
        Global.E1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=32&key=name");
        Global.E2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=33&key=name");
        Global.E3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=34&key=name");
        Global.E4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=35&key=name");
        Global.E5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=36&key=name");
        Global.E6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=37&key=name");
        Global.E7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=38&key=name");
        Global.E8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=39&key=name");
        Global.F1 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=40&key=name");
        Global.F2 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=41&key=name");
        Global.F3 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=42&key=name");
        Global.F4 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=43&key=name");
        Global.F5 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=44&key=name");
        Global.F6 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=45&key=name");
        Global.F7 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=46&key=name");
        Global.F8 = HttpWebRequest_Get.HttpWebRequest("http://localhost:5000/toggle?value=47&key=name");
        App.GetService<IAppNotificationService>().Show(string.Format("AppNotificationSamplePayload".GetLocalized(), AppContext.BaseDirectory));

        await App.GetService<IActivationService>().ActivateAsync(args);

        //endsplash
        p.Kill();
    }
}
