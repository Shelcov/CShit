using IService;
using IService.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace CShit.Controllers
{
    public class HomeController : Controller
    {
        //используем реализацию интерфейса
        IPostService _postService = new PostService();

        /// <summary>
        /// страница со всеми постами
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //получаем список постов и передаем в представление
            var list = _postService.GetPostList(new TagModel());
            return View(list);
        }
        /// <summary>
        /// коркретный пост
        /// </summary>
        /// <returns></returns>
        public ActionResult Post(int id)
        {
            //получаем текущего пользователя (для авторства)
            //var user = User.Identity.GetUserName();

            var model = _postService.GetPost(id);
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}