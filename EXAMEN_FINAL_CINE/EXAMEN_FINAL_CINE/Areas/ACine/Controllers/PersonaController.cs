using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class PersonaController : Controller
    {
        // GET: ACine/Persona
        public ActionResult Index()
        {
            ViewBag.ListadoPersona = DAPersonaa.ListadoPersona();
            return View();
        }

        public ActionResult Registro()
        {

            ViewBag.ListadoPersona = DAPersonaa.ListadoPersona();

            return View();
        }
        [HttpPost]
        public ActionResult Registro(Persona persona)
        {
            //para cargar la data
            bool exito = DAPersonaa.RegistrarPersona(persona);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DAPersonaa.EliminarPersona(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            Persona empresa = DAPersonaa.ListadoPersona().FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(Persona persona)
        {
            //para cargar la data
            bool exito = DAPersonaa.ActualizarPersona(persona);

            return RedirectToAction("Index");

        }

    }
}
