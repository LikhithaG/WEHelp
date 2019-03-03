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
            ViewBag.Scholorships = _entity.Scholorships.ToList();
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        [Route("Scholarship/ScholarshipDetails/{id}")]
        public ActionResult ScholarshipDetails(int id)
        {
            ViewBag.Scholorships = _entity.Scholorships.Where(isnt => isnt.ID == id).ToArray()[0];
            return View();
        }
    }
}