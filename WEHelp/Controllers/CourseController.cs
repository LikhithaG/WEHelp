using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEHelp.Controllers
{
    public class CourseController : Controller
    {
        WEHelpdbEntities _entity;

        public CourseController()
        {
            _entity = new WEHelpdbEntities();
        }

        // GET: Course
        public ActionResult Index()
        {
            ViewBag.Institutions = _entity.Institutions.ToList();
            return View();
        }
        [Route("course/CourseDetails/{id}")]
        public ActionResult CourseDetails(int id)
        {
            ViewBag.Institution = _entity.Institutions.Where(isnt => isnt.ID == id).ToArray()[0];
            return View();
        }
    }
}