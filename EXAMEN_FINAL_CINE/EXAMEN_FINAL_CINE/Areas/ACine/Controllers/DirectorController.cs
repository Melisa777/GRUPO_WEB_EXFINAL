using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class DirectorController : Controller
    {
        // GET: ACine/Director
        public ActionResult Index()
        {

            ViewBag.ListadoDirector = DADirector.ListadoDirector();
            return View();
        }
        public ActionResult Registro()
        {

            ViewBag.ListadoDirector = DADirector.ListadoDirector();

            return View();
        }
        [HttpPost]
        public ActionResult Registro(General.Director director)
        {
            //para cargar la data
            bool exito = DADirector.RegistrarDirector(director);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DADirector.EliminarDirector(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Director empresa = DADirector.ListadoDirector().FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(General.Director cine)
        {
            //para cargar la data
            bool exito = DADirector.ActualizarDirector(cine);

            return RedirectToAction("Index");

        }



    }
}
