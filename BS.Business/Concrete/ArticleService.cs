using BS.Business.Abstract;
using BS.DataAccess.Abstract;
using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Business.Concrete
{
    public class ArticleService : IArticleService
    {
        private IArticleDAL _articleDAL;

        public ArticleService(IArticleDAL kisiDAL)
        {
            _articleDAL = kisiDAL;
        }

        public void Add(Article item)
        {
            _articleDAL.Add(item);
        }

        public void Delete(Article item)
        {
            _articleDAL.Delete(item);
        }

        public Article Get(int? ID)
        {
            return _articleDAL.Get(e => e.ID == ID);
        }

        public ICollection<Article> GetList()
        {
            return _articleDAL.GetList();
        }

        public void Update(Article item)
        {
            _articleDAL.Update(item);
        }





    }
}
