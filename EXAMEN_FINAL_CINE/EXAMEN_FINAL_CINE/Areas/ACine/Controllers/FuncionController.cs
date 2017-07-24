using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class FuncionController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ListadoFuncion = DAFuncion.ListadoFuncion();
            ViewBag.ListadoPelicula = DAFuncion.ListadoPelicula();
            
            return View();
        }

        public ActionResult Registro()
        {
            ViewBag.ListadoFuncion = DAFuncion.ListadoFuncion();
            ViewBag.ListadoPelicula = DAPELICULA.ListadoPelicula();
            return View();
        }
        [HttpPost]
        public ActionResult Registro(Funcion funcion)
        {
            bool exito = DAFuncion.RegistrarFuncion(funcion);

            return RedirectToAction("Index");

        }
        
        public ActionResult Eliminar(int ID)
        {
            bool exito = DAFuncion.EliminarFuncion(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            Funcion empresa = DAFuncion.ListadoFuncion().FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(Funcion funcion)
        {
            bool exito = DAFuncion.ActualizarFuncion(funcion);

            return RedirectToAction("Index");

        }
        
    }
    
}
