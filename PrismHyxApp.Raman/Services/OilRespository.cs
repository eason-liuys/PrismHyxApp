using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using Microsoft.EntityFrameworkCore;
using PrismHyxApp.Raman.Models;
using PrismHyxApp.Raman.Services.Contracts;

namespace PrismHyxApp.Raman.Services;

public class OilRespository:IOilRespository
{
    private readonly OilInfoDbContext _oilInfoDbContext;

    public OilRespository(OilInfoDbContext infoDbContext)
    {
        _oilInfoDbContext = infoDbContext;
    }
    public async Task<IEnumerable<OilInfo>> GetItemsAsync()
    {
        return await _oilInfoDbContext.OilInfo.ToListAsync();
    }

    public async Task<OilInfo> GetItemAsync(int id)
    {
        return await _oilInfoDbContext.OilInfo.SingleOrDefaultAsync(c => c.Id == id);
    }

    public async void InsertItemAsync(OilInfo oilInfo)
    {
        await _oilInfoDbContext.OilInfo.AddAsync(oilInfo);
        _oilInfoDbContext.SaveChanges();
    }

    public void DeleteItemAsync(int id)
    {
        var oil =_oilInfoDbContext.OilInfo.SingleOrDefaultAsync(c => c.Id==id);
        if (oil!=null)
        {
            _oilInfoDbContext.Remove(oil);
            _oilInfoDbContext.SaveChanges();
        }
           
    }
}