using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web02.Models;

namespace Web02.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Cliente cliente = new Cliente();
            cliente.dni = 73332754;
            cliente.name = "Joao";
            cliente.lastName = "Urteaga";
            cliente.age = 19;
            ViewBag.Message = "Hola " +cliente.name+" " + cliente.lastName;
            return View(cliente);
        }
    }
}