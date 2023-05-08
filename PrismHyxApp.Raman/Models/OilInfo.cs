using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace PrismHyxApp.Raman.Models
{
    public class OilInfo
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string OilNo{ get; set; }
        public string OilType { get; set; }
        public string SpectrumInfo { get; set; }
        public string PredictValue { get; set; }
        public DateTime SampleDate { get; set; }
        public string SamplePart { get; set; }
    }
}
