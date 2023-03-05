using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("EmployeeInfos")]
    [PrimaryKey("EmpId")]
    public class EmployeeInfo
    {
        public string EmpId { get; set; }
        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpPYNo { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string StationId { get; set; }
        public string EmpTypeId { get; set; }
        public string IsOn { get; set; }
        public string Remark { get; set; }
    }
}
