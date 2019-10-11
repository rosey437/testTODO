using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tareas.Models;

namespace Tareas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //            ItemsTablaModel tablaModelo= new ItemsTablaModel();

            //List<ToDoItem> items= new List<ToDoItem>();

            //var opcionesEstado= new List<string> {"Cerrado","EnPausa","EnProceso" };
            //items.Add(new ToDoItem{ Id=1,Status="Abierto", AsignedTo=""});


            //tablaModelo.Items= items;
            //tablaModelo.OptionStatus= opcionesEstado;


            //return View(tablaModelo);
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

        #region Servicio

        [HttpGet]
        public ActionResult Ticket()
        {
            //lista de tickets

            var ticket1 = new Ticket()
            {
                TicketId = 5,
                AsignatedTo = "",
                Description = "Atencion de Emails",
                Status = "CERRADO"
            };

            return Json(ticket1, JsonRequestBehavior.AllowGet);
        }

       

        [HttpPost]
        public ActionResult Ticket(Ticket ticket)
        {
            //ABIERTO, ASIGNADO, CERRADO, ES ESPERA DE USUARIO, EN PROCESO, TERMINADO
            //Cuando en el dropdownlist llegue el valor TERMINADO solo se puede pasar a ASIGNADO o EN PROCESO q

            string resultado = string.Empty;

            return Json(new { Resultado = resultado, ticket }, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}