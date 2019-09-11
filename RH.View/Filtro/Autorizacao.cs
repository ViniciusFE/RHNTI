 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RH.View.Filtro
{
    public class Autorizacao:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuario=filterContext.HttpContext.Session["TypeUser"];            

            if(usuario==null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new {controller="Login",action="Index"}
                        )
                    );
            }
        }
    }
}
