using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFDemo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //DataEntities FEDASEntities
            //FEDASEntities _db = new FEDASEntities();
            DataEntities _db = new DataEntities();

            List<Blog> cd = _db.Blog.ToList();
            foreach (var c in cd)
            {
                Response.Write(c.Id + c.Title);
            }

            if (cd.Count < 1)
            {
                Blog blog = new Blog();
                blog.Title = "demo";
                _db.Blog.Add(blog);
                _db.SaveChanges();
            }
        }
    }
}