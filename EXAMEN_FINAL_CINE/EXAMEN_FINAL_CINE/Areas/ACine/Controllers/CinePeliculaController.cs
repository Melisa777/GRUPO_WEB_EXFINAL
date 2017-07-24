using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;
namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class CinePeliculaController : Controller
    {
        // GET: ACine/CinePelicula
        public ActionResult Index()
        {
            ViewBag.ListadoCinePelicula = DACinePelicula.ListadoCinePelicula();
            ViewBag.ListadoPelicula = DACinePelicula.ListadoPelicula();
            ViewBag.ListadoCine = DACinePelicula.ListadoCine();
            return View();
        }
        public ActionResult Registro()
        {
            ViewBag.ListadoCinePelicula = DACinePelicula.ListadoCinePelicula();
            ViewBag.ListadoCine = DACine.ListadoCine();
            ViewBag.ListadoPelicula = DAPELICULA.ListadoPelicula();
            return View();
        }
        [HttpPost]
        public ActionResult Registro(General.CinePelicula cinepelicula)
        {
            //para cargar la data
            bool exito = DACinePelicula.RegistrarCinePelicula(cinepelicula);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DACinePelicula.EliminarCinePelicula(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.CinePelicula empresa = DACinePelicula.ListadoCinePelicula().FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(General.CinePelicula producto)
        {
            //para cargar la data
            bool exito = DACinePelicula.ActualizarCinePelicula(producto);
            
            return RedirectToAction("Index");

        }



    }


}
