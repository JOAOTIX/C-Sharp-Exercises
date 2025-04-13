using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web02.Models;

namespace Web02.Controllers
{
    public class ListadoController : Controller
    {
        // GET: Listado
        public ActionResult Reporte()
        {
            List<Cliente> listaCli = new List<Cliente>();

            listaCli.Add(new Cliente { dni = 2054, name = "JAIME", lastName = "UWU", age = 20 });
            listaCli.Add(new Cliente { dni = 5254, name = "XIOMARA", lastName = "OWO", age = 26 });

            listaCli.Add(new Cliente { dni = 5000, name = "ANDREA", lastName = "AWA", age = 28 });

            listaCli.Add(new Cliente { dni = 5020, name = "CARLO", lastName = "EWE", age = 19 });

            listaCli.Add(new Cliente { dni = 5758, name = "JUAN", lastName = "UNU", age = 30 });

            return View(listaCli);
        }
    }
}