using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class InterpreteController : Controller
    {
        // GET: ACine/Interprete
        public ActionResult Index()
        {
            ViewBag.ListadoInterprete = DAInterprete.ListadoInterprete();
            return View();
        }

        public ActionResult Registro()
        {

            ViewBag.ListadoInterprete = DAInterprete.ListadoInterprete();

            return View();
        }
        [HttpPost]
        public ActionResult Registro(Interprete interprete)
        {
            //para cargar la data
            bool exito = DAInterprete.RegistrarInterprete(interprete);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DAInterprete.EliminarInterprete(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            Interprete empresa = DAInterprete.ListadoInterprete().FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(Interprete interprete)
        {
            //para cargar la data
            bool exito = DAInterprete.ActualizarInterprete(interprete);

            return RedirectToAction("Index");

        }

    }
}
