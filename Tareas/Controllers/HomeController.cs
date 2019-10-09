using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tareas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ItemsTablaModel tablaModelo= new ItemsTablaModel();

List<ToDoItem> items= new List<ToDoItem>();

var opcionesEstado= new List<string> {"Cerrado","EnPausa","EnProceso" };
items.Add(new ToDoItem{ Id=1,Status="Abierto", AsignedTo=""});


tablaModelo.Items= items;
tablaModelo.OptionStatus= opcionesEstado;


return View(tablaModelo);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}