using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;
namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: ACine/Pelicula
        public ActionResult Index()
        {
            ViewBag.ListadoPelicula = DAPELICULA.ListadoPelicula();
            ViewBag.ListadoDirector = DADirector.ListadoDirector();
         
       return View();
        }

        public ActionResult Registro()
        {
            ViewBag.ListadoPelicula = DAPELICULA.ListadoPelicula();
            return View();
        }
        [HttpPost]
        public ActionResult Registro(General.Pelicula pelicula)
        {
            //para cargar la data
            bool exito = DAPELICULA.RegistrarPelicula(pelicula);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DAPELICULA.EliminarPelicula(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Pelicula peli = DAPELICULA.ListadoPelicula().Where(x => x.CodPelicula == ID).FirstOrDefault();
            return View(peli);
        }

        [HttpPost]
        public ActionResult Editar(General.Pelicula producto)
        {
            //para cargar la data
            bool exito = DAPELICULA.ActualizarPelicula(producto);
            return RedirectToAction("Index");

        }
    }
}
