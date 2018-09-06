using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace EFDemo
{
    public class FEDASEntities : DbContext
    {
        public FEDASEntities() : base("name=FEDASEntities")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FEDASEntities>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//移除复数表名的契约
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();//防止黑幕交易 要不然每次都要访问 EdmMetadata这个表
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Tag> Tag { get; set; }
    }
}