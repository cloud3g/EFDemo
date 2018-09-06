using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo
{
    public class DAL
    {
        FEDASEntities ef = new FEDASEntities();
        public IEnumerable<Company> List()
        {
            return ef.Company.ToList();
        }
    }
}