using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FEDAS
{
    public class DataEntities : DbContext
    {
        public DataEntities() : base("name=DataEntities")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataEntities>());//
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//移除复数表名的契约
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();//
        }

        public DbSet<Company> Company { get; set; }
    }
}