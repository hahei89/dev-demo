using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{ 
    public class CommandInfo
    {
        public string CommandText;//sql或存储过程名
        public SQLiteParameter[] Paras; //参数列表
        public bool IsProc; //是否是存储过程
        public CommandInfo()
        {

        }

        public CommandInfo(string comText, bool isProc)
        {
            this.CommandText = comText;
            this.IsProc = isProc;
        }

        public CommandInfo(string sqlText, bool isProc, SQLiteParameter[] para)
        {
            this.CommandText = sqlText;
            this.Paras = para;
            this.IsProc = isProc;
        }
    }
}
