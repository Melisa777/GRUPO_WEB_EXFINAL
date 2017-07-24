using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;

namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class SalaController : Controller
    {
        // GET: ACine/Sala
        public ActionResult Index()
        {
            ViewBag.ListadoSala = DASala.ListadoSala();
            ViewBag.ListadoCine = DASala.ListadoCine();

            return View();
        }

        public ActionResult Registro()
        {
            ViewBag.Listado2 = DASala.ListadoSala();
            return View();
        }

        [HttpPost]
        public ActionResult Registro(General.Sala sala)
        {
            //para cargar la data
            bool exito = DASala.RegistrarSala(sala);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DASala.EliminarSala(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Sala empresa = DASala.ListadoSala().Where(x => x.CodSala == ID).FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(General.Sala sala)
        {
            //para cargar la data
            bool exito = DASala.ActualizarSala(sala);
            return RedirectToAction("Index");

        }
    }
}
