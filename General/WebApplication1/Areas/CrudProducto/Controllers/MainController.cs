using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General;
namespace WebApplication1.Areas.CrudProducto.Controllers
{
    public class MainController : Controller
    {
        // GET: CrudProducto/Main
        public ActionResult Index()
        {
            ViewBag.ListadoProducto = DAProducto.ListadoProducto();
            ViewBag.ListadoProveedor = DAProducto.ListadoProveedor();
            ViewBag.ListadoCategoria = DAProducto.ListadoCategoria();
            return View();
        }

        public ActionResult Registro()
        {
            ViewBag.ListadoEmpresa = DAProducto.ListadoProducto();
            return View();
        }
        [HttpPost]
        public ActionResult Registro(General.Products producto)
        {
            //para cargar la data
            bool exito = DAProducto.RegistrarProducto(producto);

            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int ID)
        {
            bool exito = DAProducto.EliminarProducto(ID);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ID)
        {
            General.Products empresa = DAProducto.ListadoProducto().Where(x => x.ProductID == ID).FirstOrDefault();
            return View(empresa);
        }
        [HttpPost]
        public ActionResult Editar(General.Products producto)
        {
            //para cargar la data
            bool exito = DAProducto.ActualizarProducto(producto);
            return RedirectToAction("Index");

        }

    }
}