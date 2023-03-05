using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("ExpressTypeInfos")]
    [PrimaryKey("ETypeId")]
    public class ExpressTypeInfo
    {
        public string ETypeId { get; set; }
        public string ETypeName { get; set; }
        public string ETypePYNo { get; set; }
        public string ParentId { get; set; }
        public int OrderNum { get; set; }
        public string remark { get; set; }
    }
}
