using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using MachineVision_Project.Services;
using MachineVision_Project.ViewModels;

namespace MachineVision_Project
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = new MainWindow();
            mainWindow.DataContext = ServiceProvider.GetRequiredService<MainViewModel>(); //Injecting MainWIndow VM
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // Register services
            services.AddSingleton<IMessageService, MessageService>();

            // Register ViewModels
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<SenderViewModel>();
            services.AddSingleton<ReceiverViewModel>();
        }
    }
}
