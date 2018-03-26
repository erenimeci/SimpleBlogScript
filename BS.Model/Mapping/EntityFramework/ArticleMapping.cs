using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model.Mapping.EntityFramework
{
    public class ArticleMapping : EntityTypeConfiguration<Article>
    {

        public ArticleMapping()
        {
            HasKey(e => e.ID);

            Property(e => e.ArticleTitle).IsRequired();
        }

    }
}
