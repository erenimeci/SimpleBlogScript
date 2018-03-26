using BS.Core.DataAccess.EntityFramework;
using BS.DataAccess.Abstract;
using BS.DataAccess.Concrete.EntityFramework.Context;
using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.DataAccess.Concrete.EntityFramework.Entities
{
    public class EFArticleDAL : EFEntityRepositoryBase<Article, ApplicationDbContext>, IArticleDAL
    {
    }
}
