using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FEDAS
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataEntities _db = new DataEntities();
            List<Company> cd = _db.Company.ToList();
            foreach (var c in cd)
            {
                Response.Write(c.Id + c.Name);
                //Response.Write(c.ToString());
            }
        }
    }
}