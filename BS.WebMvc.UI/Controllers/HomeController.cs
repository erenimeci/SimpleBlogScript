using BS.Business.Abstract;
using BS.WebMvc.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BS.WebMvc.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IArticleService _articleService;

        public HomeController(IUserService userService, IArticleService articleService)
        {
            _userService = userService;
            _articleService = articleService;

        }

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            _userService.GetList();
            _articleService.GetList();
            HomeViewModel model = new HomeViewModel();
            model.User = _userService.GetList().ToList();
            model.Article = _articleService.GetList().ToList();

            return View(model);
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(FormCollection formcollection)
        {
            _userService.GetList();
            HomeViewModel model = new HomeViewModel();
            model.User = _userService.GetList().ToList();

            string userName = formcollection["userName"];
            string userPass = formcollection["userPass"];

            try
            {
                BS.Model.Entities.User kisi = _userService.GetByUserName(userName);
                if (kisi.UserPass == userPass)
                {
                    Session["User"] = kisi;
                    return RedirectToAction("Index", "Admin");
                }

            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SignIn(FormCollection formcollection)
        {

            string SignUserName = formcollection["SignUserName"];
            string SignName = formcollection["SignName"];
            string Signsurname = formcollection["Signsurname"];
            string SignuserPass = formcollection["SignuserPass"];

            try
            {
                BS.Model.Entities.User yeniKisi = new Model.Entities.User
                {
                    Name = SignName,
                    Surname = Signsurname,
                    UserName = SignUserName,
                    UserPass = SignuserPass
                };

                _userService.Add(yeniKisi);


            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index", "Home");

        }


    }
}