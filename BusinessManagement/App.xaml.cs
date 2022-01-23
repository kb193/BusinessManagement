using BusinessManagement.Data;
using BusinessManagement.MVVM.View;
using BusinessManagement.MVVM.ViewModel;
using BusinessManagement.MVVM.ViewModel.Contracts;
using BusinessManagement.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;
        private IConfiguration _configuration;
        public App()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            var cxs = _configuration.GetConnectionString("BusinessManagement");
            services.AddCustomServices(cxs);

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IDashboardViewModel, DashboardViewModel>();
            services.AddTransient<ICustomersViewModel, CustomersViewModel>();
            services.AddTransient<ISuppliersViewModel, SuppliersViewModel>();
            services.AddTransient<IAddCustomerViewModel, AddCustomerViewModel>();
            services.AddTransient<ICustomersGridViewModel, CustomersGridViewModel>();

            services.AddSingleton<HomeView>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
        }

        private void OnStartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
