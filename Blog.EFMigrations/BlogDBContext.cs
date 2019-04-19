using Blog.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EFMigrations
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext()
           : base("Name=BlogCoreDBContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlogDBContext>());
        }

        public System.Data.Entity.DbSet<UserInfo> UserInfo { get; set; }

        public System.Data.Entity.DbSet<UserType> UserType { get; set; } 

        public System.Data.Entity.DbSet<Article> Article { get; set; }

        public System.Data.Entity.DbSet<ArticleType> ArticleType { get; set; }

        public System.Data.Entity.DbSet<Inform> Inform { get; set; }

        public System.Data.Entity.DbSet<Comment> Comment { get; set; }

        public System.Data.Entity.DbSet<reply> reply { get; set; }

    }
}
