using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFDemo
{
    [Table("Tag")]
    public class Tag
    {
        public Tag()
        {
            Blogs = new HashSet<Blog>();
        }

        [Column("Id", TypeName = "int", Order = 1)]
        public virtual int Id { get; set; }

        [DisplayName("名称")]
        [Column("Name", TypeName = "varchar", Order = 2), MaxLength(12)]
        public virtual string Name { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}