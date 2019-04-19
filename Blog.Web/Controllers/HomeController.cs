using Blog.IService.interfaceML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        public IArticles OpenArticles { get; set; }

        // GET: Home
        public ActionResult Index(int? id)
        {
            int Pagecouns;
            var data = OpenArticles.ArticlesSortTime(out Pagecouns).ToList();
            ViewBag.Count = Pagecouns;
            ViewBag.id = id == null ? 1 : id;
            return View(data);
        }
    }
}