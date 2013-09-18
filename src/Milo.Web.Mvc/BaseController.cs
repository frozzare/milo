using System.Web.Mvc;

namespace Milo.Web.Mvc
{
    /// <summary>
    /// Abstract base class for MVC projects using Milo CMS.
    /// </summary>
    public abstract class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}
