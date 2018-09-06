using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo
{
    [Table("Blog")]
    public class Blog
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }
    }
}