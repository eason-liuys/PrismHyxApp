using Prism.Mvvm;
using Prism.Regions;
using PrismHyxApp.Raman.Base;
using PrismHyxApp.Raman.Services.Contracts;

namespace PrismHyxApp.Raman.ViewModels
{
    public class MainWindowViewModel : BindableBase,IConfigureService
    {
        private string _title = "Prism Application";
        private readonly IRegionManager _regionManager;

        public string Title
        {
            get => _title; 
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Configure()
        {
            _regionManager.Regions[PrismManager.RamanMainViewRegionName].RequestNavigate("MainPage");
        }
    }
}
