using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model.Models;

namespace Web.Data
{
    public class APIDbContext: DbContext
    {
        public APIDbContext() : base("DBAPIConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Oder> Oders { get; set; }
        public DbSet<OderDetail> OderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide>  Slides{ get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs  { get; set; }
        public DbSet<Tag> Tags  { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics  { get; set; }
        protected override void OnModelCreating(DbModelBuilder Builder)
        {
            
        }
    }
}
