using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FEDAS
{
    [Table("Company")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "varchar"), MaxLength(50)]
        public string Name { get; set; }

        [Column("Logo", TypeName = "varchar"), MaxLength(50)]
        public string Logo { get; set; }

        [Column("SystemCnName", TypeName = "varchar"), MaxLength(50)]
        public string SystemCnName { get; set; }

        [Column("SystemEnName", TypeName = "varchar"), MaxLength(100)]
        public string SystemEnName { get; set; }

        [Column("Color", TypeName = "varchar"), MaxLength(10)]
        public string Color { get; set; }

        [Column("Banner", TypeName = "varchar"), MaxLength(50)]
        public string Banner { get; set; }

        [Column("Phone", TypeName = "varchar"), MaxLength(50)]
        public string Phone { get; set; }

        public System.DateTime AddTime { get; set; }

        [Column("Remark", TypeName = "varchar(MAX)")]
        public string Remark { get; set; }

        [Column("AdminId", TypeName = "int")]
        public int AdminId { get; set; }

        [Column("PushOffline", TypeName = "bit")]
        public bool PushOffline { get; set; }

        [Column("SMSAllow", TypeName = "bit")]
        public bool SMSAllow { get; set; }

        [Column("MemberId", TypeName = "int")]
        public Nullable<int> MemberId { get; set; }

        override public string ToString()
        {
            string str = String.Empty;
            str = String.Concat(str, "Id = ", Id, "\r\n");
            str = String.Concat(str, "Name = ", Name, "\r\n");
            str = String.Concat(str, "Logo = ", Logo, "\r\n");
            str = String.Concat(str, "SystemCnName = ", SystemCnName, "\r\n");
            str = String.Concat(str, "SystemEnName = ", SystemEnName, "\r\n");
            str = String.Concat(str, "Color = ", Color, "\r\n");
            str = String.Concat(str, "Banner = ", Banner, "\r\n");
            str = String.Concat(str, "Phone = ", Phone, "\r\n");
            str = String.Concat(str, "AddTime = ", AddTime, "\r\n");
            str = String.Concat(str, "Remark = ", Remark, "\r\n");
            str = String.Concat(str, "AdminId = ", AdminId, "\r\n");
            str = String.Concat(str, "PushOffline = ", PushOffline, "\r\n");
            str = String.Concat(str, "SMSAllow = ", SMSAllow, "\r\n");
            str = String.Concat(str, "MemberId = ", MemberId, "\r\n");
            return str;
        }
    }
}