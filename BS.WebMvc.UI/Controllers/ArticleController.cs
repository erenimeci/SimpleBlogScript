using BS.Business.Abstract;
using BS.WebMvc.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BS.WebMvc.UI.Controllers
{
    public class ArticleController : Controller
    {

        private readonly IArticleService _articleService;


        public ArticleController(IArticleService articleService, IUserService userService)
        {
            _articleService = articleService;
        }


        // GET: Article
        public ActionResult Index(int ID)
        {

            ArticleViewModel article = new ArticleViewModel();
            if (ID != null)
            {
                article.Article = _articleService.Get(ID);
            }
            return View(article);
        }
    }
}