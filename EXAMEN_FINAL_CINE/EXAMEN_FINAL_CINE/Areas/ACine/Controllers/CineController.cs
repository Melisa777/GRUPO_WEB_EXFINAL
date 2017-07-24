using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class CineController : Controller
    {
        // GET: ACine/Cine
        public ActionResult Index()
        {
         
            ViewBag.ListadoCine = DACine.ListadoCine();
            return View();
        }
        public ActionResult Registro()
        {
          
            ViewBag.ListadoCine = DACine.ListadoCine();
            
            return View();
        }
        [HttpPost]
        public ActionResult Registro(General.Cine cine)
        {
            //para cargar la data
            bool exito = DACine.RegistrarCine(cine);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DACine.EliminarCine(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Cine empresa = DACine.ListadoCine().FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(General.Cine cine)
        {
            //para cargar la data
            bool exito = DACine.ActualizarCine(cine);

            return RedirectToAction("Index");

        }



    }
}
