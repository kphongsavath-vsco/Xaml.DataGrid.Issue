using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Xaml.DataGrid.Issue.ViewModels;

namespace Xaml.DataGrid.Issue
{
    internal static class Program
    {
        private static IHost _host;

        [STAThread]
        public static void Main()
        {
            var builder = Host.CreateApplicationBuilder();

            IConfiguration configs = builder.Configuration;


            // Add the error logging service
            //builder.Services.AddSingleton<IErrorLoggingService>(new ErrorLoggingService(configs.GetConnectionString("MpaMfp")));

            // Register other services
            //builder.Services.AddTransient<IParameterViewModel, ParameterUCViewModel>();

            builder.Services.AddSingleton<App>();
            builder.Services.AddSingleton<MainWindow>();
            // Configure application settings

            builder.Services.AddSingleton<IMainWindowViewModel, MainWindowViewModel>();
            builder.Services.AddSingleton<IHomeViewModel, HomeViewModel>();
            //builder.Services.AddActivatedSingleton<ITravelRetailViewModel, TravelRetailViewModel>();

            // Build the host
            _host = builder.Build();

            // Run the app
            var app = _host.Services.GetRequiredService<App>();

            _host.Start();

            app.Run();

            _host.StopAsync().GetAwaiter().GetResult();

        }



        public static IServiceProvider Services => _host.Services;
    }
}
