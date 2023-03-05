using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("EmpTypeInfos")]
    [PrimaryKey("EmpTypeId")]
    public class EmpTypeInfo
    {
        public string EmpTypeId { get; set; }
        public string EmpTypeName { get; set; }
        public string Remark { get; set; }

    }
}
