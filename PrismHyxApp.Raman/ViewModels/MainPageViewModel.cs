using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using Prism.Commands;
using Prism.Mvvm;
using PrismHyxApp.Raman.Models;
using PrismHyxApp.Raman.Services.Contracts;

namespace PrismHyxApp.Raman.ViewModels;

public class MainPageViewModel:BindableBase
{
    ///*---------------------
    private readonly IOilRespository _oilRespository;
    public MainPageViewModel(IOilRespository oilRespository)
    {
        _oilRespository = oilRespository;
        UpdateShowInfoCommand = new DelegateCommand(UpdateShowOilInfo);
        //InsertInfoCommand = new DelegateCommand<OilInfo>(InsertItem);
        DeleteInfoCommand = new DelegateCommand<OilInfo>(DeleteItem);
        //ShowCurrentCommand = new DelegateCommand(Show);
        UpdateShowOilInfo();
        SelectedOilInfo = OilInfos.First();
    }

    public DelegateCommand UpdateShowInfoCommand { get; set; }
    public ObservableCollection<OilInfo> OilInfos { get; set; } = new ObservableCollection<OilInfo>();
    public OilInfo SelectedOilInfo { get; set; }
    private void UpdateShowOilInfo()
    {
        OilInfos.Clear();
        var result = _oilRespository.GetItemsAsync().Result;
        foreach (var oilInfo in result)
        {
            OilInfos.Add(oilInfo);
        }
    }

    //public OilInfo CurrentOil { get; set; }
    //public DelegateCommand<OilInfo> InsertInfoCommand { get; set; }
    //private void InsertItem(OilInfo oilInfo)
    //{
    //    var oil = new OilInfo() { Name = "新插入油样",OilNo = "Oil0001",SampleDate = DateTime.Today};
    //    OilInfos.Add(oil);
    //    _oilRespository.InsertItemAsync(oil);
    //}

    public DelegateCommand<OilInfo> DeleteInfoCommand { get; set; }
    private void DeleteItem(OilInfo oilInfo)
    {
        OilInfos.Remove(SelectedOilInfo);
        _oilRespository.DeleteItemAsync(SelectedOilInfo.Id);
    }

    //public DelegateCommand ShowCurrentCommand { get; set; }

    //private void Show()
    //{
    //    CurrentOil = SelectedOilInfo;
    //}
    //-----------------------*/
}