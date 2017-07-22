using System.Web.Mvc;

namespace EXAMEN_FINAL_CINE.Areas.ACine
{
    public class ACineAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ACine";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ACine_default",
                "ACine/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}