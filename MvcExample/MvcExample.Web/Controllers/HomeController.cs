using System.Text;
using System.Web.Mvc;
using MvcExample.Web.Filters;

namespace MvcExample.Web.Controllers
{
    [UserAuthFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public PartialViewResult AddNewsModalDisplay()
        {
            return PartialView("_AddNewsPartial");
        }
    }
}