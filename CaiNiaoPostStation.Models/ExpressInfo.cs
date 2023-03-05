using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiNiaoPostStation.Models
{
    [Table("ExpressInfos")]
    [PrimaryKey("ExpId")]
    public class ExpressInfo
    {
        public string ExpId { get; set; }
        public string ExpNumber { get; set; }
        public string StationId { get; set; }
        public string ShelfId { get; set; }
        public string sender { get; set; }
        public string SendAddress { get; set; }
        public string SendPhone { get; set; }
        public string Receiver { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiveAddress { get; set; }
        public string ExpRemark { get; set; }
        public string ExpState { get; set; }
        public string ExpType { get; set; }
        public string EnterPerson { get; set; }
        public string EnterTime { get; set; }
        public string PickWay { get; set; }
    }
}
