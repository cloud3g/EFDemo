using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string SystemCnName { get; set; }
        public string SystemEnName { get; set; }
        public string Color { get; set; }
        public string Banner { get; set; }
        public string Phone { get; set; }
        public System.DateTime AddTime { get; set; }
        public string Remark { get; set; }
        public int AdminId { get; set; }
        public bool PushOffline { get; set; }
        public bool SMSAllow { get; set; }
        public Nullable<int> MemberId { get; set; }
    }
}