using BS.Core.DataAccess;
using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.DataAccess.Abstract
{
    public interface IArticleDAL : IEntityRepository<Article>
    {
    }
}
