using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web02.Controllers
{
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Index()
        {
            
            ViewData["fechaActual"] = DateTime.Now.ToString();

            
            return View();
        }
    }
}