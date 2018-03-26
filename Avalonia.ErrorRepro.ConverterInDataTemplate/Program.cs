using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.ErrorRepro.ConverterInDataTemplate.ViewModels;
using Avalonia.ErrorRepro.ConverterInDataTemplate.Views;

namespace Avalonia.ErrorRepro.ConverterInDataTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
