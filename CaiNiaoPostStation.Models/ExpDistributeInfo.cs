using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("ExpDistributeInfos")]
    [PrimaryKey("DistributeId")]
    public class ExpDistributeInfo
    {
        public string DistributeId { get; set; }
        public string ExpId { get; set; }
        public string EmpId { get; set; }
        public string IsSignFor { get; set; }
        public string SignTime { get; set; }
        public string DistributeTime { get; set; }
        public string InsertTime { get; set; }

    }
}
