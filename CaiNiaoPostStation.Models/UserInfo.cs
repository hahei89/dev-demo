using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("UserInfos")]
    [PrimaryKey("UserId")]
    public class UserInfo
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserPwd { get; set; }

        public bool UserState { get; set; }
    }
}
