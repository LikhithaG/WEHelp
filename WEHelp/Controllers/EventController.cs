using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEHelp.Controllers
{
    public class EventController : Controller
    {
        WEHelpdbEntities _entity;

        public EventController()
        {
            _entity = new WEHelpdbEntities();
        }

        // GET: Course
        public ActionResult Index()
        {
            ViewBag.Events = _entity.Events.ToList();
            return View();
        }
        // GET: Event
        public ActionResult SingleEvent()
        {
            return View();
        }
    }
}