using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("MenuInfos")]
    [PrimaryKey("MenuId")]
    public class MenuInfo
    {
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string ParentId { get; set; }
        public string MKey { get; set; }
        public string FrmURL { get; set; }
        public int MOrder { get; set; }
    }
}
