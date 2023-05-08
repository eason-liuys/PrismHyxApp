using Prism.Ioc;
using PrismHyxApp.Raman.Views;
using System.Windows;
using PrismHyxApp.Raman.Services;
using PrismHyxApp.Raman.Services.Contracts;
using PrismHyxApp.Raman.ViewModels;

namespace PrismHyxApp.Raman
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MessageView, MessageViewModel>();
            containerRegistry.RegisterSingleton<IOilRespository,OilRespository>();
        }

        protected override void Initialize()
        {
            base.Initialize();
            var service =
                App.Current.MainWindow.DataContext as IConfigureService;
            service?.Configure();
        }
    }
}
