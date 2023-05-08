using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevExpress.Office.Tsp;
using PrismHyxApp.Raman.Models;

namespace PrismHyxApp.Raman.Services.Contracts;

public interface IOilRespository
{
    Task<IEnumerable<OilInfo>> GetItemsAsync();
    Task<OilInfo> GetItemAsync(int id);
    void InsertItemAsync(OilInfo oilInfo);
    void DeleteItemAsync(int id);

}