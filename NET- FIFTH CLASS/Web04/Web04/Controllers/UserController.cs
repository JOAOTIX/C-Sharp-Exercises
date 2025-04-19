using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web04.Models;

namespace Web04.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Users()
        {
            List<User> list = new List<User> ();
            ConectarBD conectar = new ConectarBD ();
            list=conectar.ListarUser();
            return View(list);
        }
        [HttpPost]
        public ActionResult Save(User usu)
        {
            ConectarBD conectar = new ConectarBD();
            conectar.AgregarUsuario(usu);

            return RedirectToAction("Users");
        }
        [HttpGet]
        public ActionResult Agregar() {
            return View("Save");
        }
    }
}