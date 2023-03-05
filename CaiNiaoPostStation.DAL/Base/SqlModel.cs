using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.DAL.Base
{
    /// <summary>
    /// 生成的Sql语句实体（Insert/Update语句生成的内容）
    /// </summary>
     public class SqlModel
    {
        public string Sql { get; set; }
        public SQLiteParameter[] Paras { get; set; }
    }
}
