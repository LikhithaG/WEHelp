using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEHelp.Controllers
{
    public class ScholarshipController : Controller
    {
        WEHelpdbEntities _entity;

        public ScholarshipController()
        {
            _entity = new WEHelpdbEntities();
        }

        // GET: Scholarship
        public ActionResult Index()
        {
            ViewBag.Scholarships = _entity.Scholorships.ToList();
            return View();
        }
        
        public ActionResult ScholarshipDetails()
        {
            return View();
        }
    }
}