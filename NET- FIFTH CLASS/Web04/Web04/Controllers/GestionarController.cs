using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web04.Models;
using ZstdSharp.Unsafe;

namespace Web04.Controllers
{
    public class GestionarController : Controller
    {
        // GET: Gestionar
        public ActionResult Home()
        {
            
            List<Producto> list = new List<Producto>();
            ConectarBD conectarBD = new ConectarBD();
            list= conectarBD.ListarProducto();

            return View(list);
        }
        // for the save product
        [HttpPost]
        public ActionResult Save(Producto producto)
        {
            ConectarBD conectarBD = new ConectarBD();
            conectarBD.AgregarProducto(producto);
            

            return RedirectToAction("Home");
        }
        // for the edit product
        [HttpGet]
        public ActionResult EditarProducto(int code)
        {
            ConectarBD conectarBD = new ConectarBD();
            Producto producto = new Producto();
            producto=conectarBD.CosultarIdProducto(code);
            return View(producto);
        }
        //Method for the update product
        [HttpPost]
        public ActionResult Actualizar(Producto prod)
        {
            ConectarBD conectarBD = new ConectarBD();
            conectarBD.ActualizarProducto(prod);
            return RedirectToAction("Home");
        }
        //For the delete product
        [HttpGet]
        public ActionResult EliminarProducto(int code)
        {
            ConectarBD conectarBD = new ConectarBD();
            conectarBD.EliminarProducto(code);
            return RedirectToAction("Home");
        }
        //to redirect to the Save page
        [HttpGet]
        public ActionResult Agregar() { 
            return View("Save");
        }
        
    }
}