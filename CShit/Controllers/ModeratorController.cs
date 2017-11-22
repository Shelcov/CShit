using IService;
using IService.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CShit.Controllers
{
    public class ModeratorController : Controller
    {
        // GET: Moderator

        ITagService _tagService = new TagService();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tags()
        {
            _tagService.AddTag(new TagModel()
            {
                Name = "first tag",
                UrlName = "f_tag"
            });
            var list = _tagService.GetTagList();
            return View(list);
        }
    }
}