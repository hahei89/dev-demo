using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("ShelfInfos")]
    [PrimaryKey("ShelfId")]
    public class ShelfInfos
    {
        public string ShelfId { get; set; }
        public string ShelfName { get; set;}
        public string ShelfNo { get; set; }
        public string StationId { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
    }
}
