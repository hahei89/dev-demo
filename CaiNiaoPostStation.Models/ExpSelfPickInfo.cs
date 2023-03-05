using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("ExpSelfPickInfos")]
    [PrimaryKey("PickUpId")]
    public class ExpSelfPickInfo
    {
        public string PickUpId { get; set; }
        public string ExpId { get; set; }
        public string PickingCode { get; set; }
        public bool IsPickUp { get; set; }
        public string PickingTime { get; set; }
        public string InsertTime { get; set; }
    }
}
