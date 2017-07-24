using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class TicketController : Controller
    {
        // GET: ACine/Ticket
        public ActionResult Index()
        {

            ViewBag.ListadoTicket = DATicket.ListadoTicket();
            ViewBag.ListadoAsiento = DAAsiento.ListadoAsiento();
            ViewBag.ListadoPersona = DAPersonaa.ListadoPersona();
            ViewBag.ListadoFuncion = DAFuncion.ListadoFuncion();

            return View();
        }
        public ActionResult Registro()
        {

            ViewBag.ListadoTicket = DATicket.ListadoTicket();
            return View();
        }
    
        [HttpPost]
        public ActionResult Registro(General.Ticket ticket)
        {
            //para cargar la data
            bool exito = DATicket.RegistrarTicket(ticket);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DATicket.EliminarTicket(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Ticket ti = DATicket.ListadoTicket().FirstOrDefault();
            return View(ti);
        }

        [HttpPost]
        public ActionResult Editar(General.Ticket ticket)
        {
            //para cargar la data
            bool exito = DATicket.ActualizarTicket(ticket);

            return RedirectToAction("Index");

        }



    }
}