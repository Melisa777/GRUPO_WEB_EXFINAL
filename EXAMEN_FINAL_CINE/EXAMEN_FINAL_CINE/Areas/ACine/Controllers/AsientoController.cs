using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;
namespace EXAMEN_FINAL_CINE.Areas.ACine.Controllers
{
    public class AsientoController : Controller
    {
        // GET: ACine/Asiento
        public ActionResult Index()
        {
            ViewBag.ListadoAsiento = DAAsiento.ListadoAsiento();
            ViewBag.ListadoProveedor = DAAsiento.ListadoSala();

            return View();
        }


        public ActionResult Registro()
        {
            ViewBag.Listado2 = DAAsiento.ListadoAsiento();
            return View();
        }

        [HttpPost]
        public ActionResult Registro(General.Asiento asiento)
        {
            //para cargar la data
            bool exito = DAAsiento.RegistrarAsiento(asiento);

            return RedirectToAction("Index");

        }

        public ActionResult Eliminar(int ID)
        {
            bool exito = DAAsiento.EliminarAsiento(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Asiento empresa = DAAsiento.ListadoAsiento().Where(x => x.CodAsiento == ID).FirstOrDefault();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Editar(General.Asiento asiento)
        {
            //para cargar la data
            bool exito = DAAsiento.ActualizarAsiento(asiento);
            return RedirectToAction("Index");

        }
    }

}
