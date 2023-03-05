using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("StationInfos")]
    [PrimaryKey("StationId")]
    public class StationInfo
    {
        public string StationId { get; set; }

        public string StationNo { get; set; }

        public string StationName { get; set; }
        public string StationPYNo { get; set;}
        public string Address { get; set; }
        public string Manager { get; set; }
        public string Phone { get; set; }

        public string Remark { get; set; }

        public bool isRunning { get; set; }
    }
}
