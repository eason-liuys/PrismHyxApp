using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace PrismHyxApp.Raman.Models
{
    public class OilInfoDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = D:\3-Coding\CSharp\PrismHyxApp\PrismHyxApp.Raman\OilInfo.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OilInfo>().HasData(new OilInfo()
            {
                Id=1,
                Name = "0#车柴",
                OilType = JsonConvert.SerializeObject(new OilType() { TypeName = "柴油", GradeName = "0#" }),
                
            });
            modelBuilder.Entity<OilInfo>().HasData(new OilInfo()
            {
                Id=2,
                Name = "-35#军柴",
                OilType = JsonConvert.SerializeObject(new OilType() { TypeName = "柴油", GradeName = "-35#" }),
                
            });
            modelBuilder.Entity<OilInfo>().HasData(new OilInfo()
            {
                Id = 3,
                Name = "-50#军柴",
                OilType = JsonConvert.SerializeObject(new OilType() { TypeName = "柴油", GradeName = "-50#" }),
                
            });
            modelBuilder.Entity<OilInfo>().HasData(new OilInfo()
            {
                Id = 4,
                Name = "茂名通用喷气燃料",
                OilType = JsonConvert.SerializeObject(new OilType() { TypeName = "航煤", GradeName = "3#喷气燃料" }),
                
            });
            modelBuilder.Entity<OilInfo>().HasData(new OilInfo()
            {
                Id = 5,
                Name = "高闪点-驱三",
                OilType = JsonConvert.SerializeObject(new OilType() { TypeName = "航煤", GradeName = "高闪点喷气燃料" }),
                
            });
        }

        public DbSet<OilInfo> OilInfo { get; set; }
    }
}
