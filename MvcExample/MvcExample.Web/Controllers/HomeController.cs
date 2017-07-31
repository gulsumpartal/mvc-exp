using System.Text;
using System.Web.Mvc;

namespace MvcExample.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        
    }
}