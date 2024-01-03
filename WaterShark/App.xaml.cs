using System.Diagnostics;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;

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
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<SettingsPage>();
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
        public static string classws;
        public static string classks;
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
        public static string TA1;
        public static string TA2;
        public static string TA3;
        public static string TA4;
        public static string TA5;
        public static string TA6;
        public static string TA7;
        public static string TA8;
        public static string TB1;
        public static string TB2;
        public static string TB3;
        public static string TB4;
        public static string TB5;
        public static string TB6;
        public static string TB7;
        public static string TB8;
        public static string TC1;
        public static string TC2;
        public static string TC3;
        public static string TC4;
        public static string TC5;
        public static string TC6;
        public static string TC7;
        public static string TC8;
        public static string TD1;
        public static string TD2;
        public static string TD3;
        public static string TD4;
        public static string TD5;
        public static string TD6;
        public static string TD7;
        public static string TD8;
        public static string TE1;
        public static string TE2;
        public static string TE3;
        public static string TE4;
        public static string TE5;
        public static string TE6;
        public static string TE7;
        public static string TE8;
        public static string TF1;
        public static string TF2;
        public static string TF3;
        public static string TF4;
        public static string TF5;
        public static string TF6;
        public static string TF7;
        public static string TF8;
    }
    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        
        base.OnLaunched(args);
        //spalsh
        Thread splash = new Thread(waitforkill);
        splash.Start();
        
        GettingScr.nm();
        GettingScr.getcl();

        //App.GetService<IAppNotificationService>().Show(string.Format("AppNotificationSamplePayload".GetLocalized(), AppContext.BaseDirectory));

        await App.GetService<IActivationService>().ActivateAsync(args);
        Thread.Sleep(9000);

    }
    public void waitforkill()
    {
        Thread.Sleep(10000);
    }
}
