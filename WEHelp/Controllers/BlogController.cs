using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEHelp.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult SingleBlog()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}