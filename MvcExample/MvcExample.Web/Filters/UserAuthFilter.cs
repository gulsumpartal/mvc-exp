using System.Web.Mvc;
using System.Web.Routing;
using MvcExample.Common.Helpers;

namespace MvcExample.Web.Filters
{
    public class UserAuthFilter :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (UserHelper.CurrentUser == null)
            {
                RouteValueDictionary redirectTargetDictionary = new RouteValueDictionary();

                redirectTargetDictionary.Add("action", "Login");
                redirectTargetDictionary.Add("controller", "Auth");

                filterContext.Result = new RedirectToRouteResult(redirectTargetDictionary);
            }
        }
    }
}