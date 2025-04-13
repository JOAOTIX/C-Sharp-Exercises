using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web02.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            List<String> list = new List<String>();
            list.Add("Juan");
            list.Add("Joao");
            list.Add("Jaime");
            list.Add("Jamaica");
            list.Add("Walter");
            ViewBag.NameList = list;
            return View();
        }
    }
}