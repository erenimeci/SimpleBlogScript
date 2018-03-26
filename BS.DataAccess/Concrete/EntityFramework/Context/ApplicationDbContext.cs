using BS.Model.Entities;
using BS.Model.Mapping.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.DataAccess.Concrete.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("Server=.;Database=BS.DB;Integrated Security=true")
        {



        }

        #region Entities
        public DbSet<User> Kisi { get; set; }
        public DbSet<Article> Adres { get; set; }
        #endregion



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new ArticleMapping());
        }

    }
}
