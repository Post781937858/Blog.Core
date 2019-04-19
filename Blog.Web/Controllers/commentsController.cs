using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class commentsController : Controller
    {
        // GET: comments
        public ActionResult Index()
        {
            return View();
        }
    }
}