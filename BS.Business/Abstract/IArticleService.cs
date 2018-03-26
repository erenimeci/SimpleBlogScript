using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Business.Abstract
{
    public interface IArticleService
    {

        Article Get(int? ID);
        ICollection<Article> GetList();
        void Add(Article entity);
        void Update(Article entity);
        void Delete(Article entity);
   


    }
}
