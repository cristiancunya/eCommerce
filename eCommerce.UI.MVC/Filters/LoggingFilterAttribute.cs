using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.UI.MVC.Filters
{
    public class LoggingFilterAttribute: ActionFilterAttribute
    {
        protected static readonly log4net.ILog log =
             log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //Antes de que el action method se ejecute.
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var message = string.Format("Inicia ejecucion de: Controller {0}, Action {1}, Hora Inicio {2}",
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                filterContext.ActionDescriptor.ActionName,
                DateTime.Now.ToLongTimeString());
            log.Debug(message);
        }

        //Despues de que el action method se ejecutó.
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var message = string.Format("Termina ejecucion de: Controller {0}, Action {1}, Hora Fin {2}",
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                filterContext.ActionDescriptor.ActionName,
                DateTime.Now.ToLongTimeString());
            log.Debug(message);
        }
    }
}