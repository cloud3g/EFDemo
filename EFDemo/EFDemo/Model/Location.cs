using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public byte State { get; set; }
        public Nullable<int> ParentId { get; set; }
        public System.DateTime AddTime { get; set; }
        public string Remark { get; set; }
        public string Mobile { get; set; }
    }
}