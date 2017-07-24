using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class ProtagonistaController : Controller
    {
        // GET: ACine/Protagonista
        // GET: ACine/CinePelicula
        public ActionResult Index()
        {
            ViewBag.ListadoProtagonista = DAProtagonista.ListadoProtagonista();
            ViewBag.ListadoInterprete = DAInterprete.ListadoInterprete();
            ViewBag.ListadoPelicula = DAPELICULA.ListadoPelicula();
            return View();
        }
        public ActionResult Registro()
        {
            ViewBag.ListadoProtagonista = DAProtagonista.ListadoProtagonista();
            ViewBag.ListadoInterprete = DAInterprete.ListadoInterprete();
            ViewBag.ListadoPelicula = DAPELICULA.ListadoPelicula();
            return View();
        }
        [HttpPost]
        public ActionResult Registro(General.Protagonista protagonista)
        {
            //para cargar la data
            bool exito = DAProtagonista.RegistrarProtagonista(protagonista);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DAProtagonista.EliminarProtagonista(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Protagonista PELI = DAProtagonista.ListadoProtagonista().FirstOrDefault();
            return View(PELI);
        }

        [HttpPost]
        public ActionResult Editar(General.Protagonista PRO)
        {
            //para cargar la data
            bool exito = DAProtagonista.ActualizarProtagonista(PRO);

            return RedirectToAction("Index");

        }



    }


}
