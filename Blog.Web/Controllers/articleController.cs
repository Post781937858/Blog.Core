using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class articleController : Controller
    {
        // GET: article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult detail(int id)
        {
            return View();
        }
    }
}