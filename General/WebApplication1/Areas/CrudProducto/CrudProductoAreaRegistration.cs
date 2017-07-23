using System.Web.Mvc;

namespace WebApplication1.Areas.CrudProducto
{
    public class CrudProductoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CrudProducto";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CrudProducto_default",
                "CrudProducto/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}