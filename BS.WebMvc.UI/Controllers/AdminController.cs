using BS.Business.Abstract;
using BS.Model.Entities;
using BS.WebMvc.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BS.WebMvc.UI.Controllers
{
    public class AdminController : Controller
    {


        private readonly IArticleService _articleService;
        private readonly IUserService _userService;


        public AdminController(IArticleService articleService, IUserService userService)
        {
            _articleService = articleService;
            _userService = userService;
        }

        // GET: Admin
        public ActionResult Index()
        {

            HomeViewModel model = new HomeViewModel { Article = _articleService.GetList() };
            return View(model);
        }

        public ActionResult NewArticle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewArticle(ArticleViewModel model)
        {
            Article article = model.Article;
            article.CreatedAt = DateTime.Now;

            BS.Model.Entities.User user = ((BS.Model.Entities.User)(Session["User"]));
            article.CreatedBy = user;
            
            try
            {
                _articleService.Add(article);
            }
            catch (Exception)
            {
            }

            return Redirect("/Admin/Index");
        }

        [HttpGet]
        public ActionResult RemoveArticle(int ID)
        {
            ArticleViewModel article = new ArticleViewModel();
            article.Article = _articleService.Get(ID);

            return View(article);
        }


        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("RemoveArticle")]
        public ActionResult ArticleSilelimMi(int ID)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Article article = _articleService.Get(ID);
                    _articleService.Delete(article);
                }
            }
            catch (Exception)
            {
            }

            return Redirect("/Admin/Index");
        }

        [HttpGet]
        public ActionResult EditArticle(int ID)
        {
            ArticleViewModel article = new ArticleViewModel();
            if (ID != null)
            {
                article.Article = _articleService.Get(ID);
            }
            return View(article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditArticle(ArticleViewModel model)
        {
            if (model.Article.ID != null)
            {
                try
                {
                    Article article = _articleService.Get(model.Article.ID);
                    article.ArticleTitle = model.Article.ArticleTitle;
                    article.ArticleText = model.Article.ArticleText;
                    article.CreatedBy = ((BS.Model.Entities.User)(Session["User"]));

                    _articleService.Update(article);
                }
                catch (Exception)
                {
                }
            }

            return Redirect("/Admin/Index");
        }

    }
}