using System.Windows;

using GalaSoft.MvvmLight.Messaging;

using TestClient.Model;
using TestClient.Views;
using TestClient.ViewModels;

namespace TestClient
{
    public partial class App
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var container = Container.Instance;
            container.RegisterAsSingleton<IDataProvider, DataProvider>();
            container.RegisterAsSingleton<IWindowService, WindowService>();

            container.RegisterInstance(typeof(IMessenger), Messenger.Default);
            container.RegisterInstance(typeof(IContainer), container);

            var mainView = container.Resolve<MainView>();
            mainView.DataContext = container.Resolve<MainViewModel>();

            var windowService = container.Resolve<IWindowService>();
            windowService.Show("Tags App", mainView);
        }
    }
}
