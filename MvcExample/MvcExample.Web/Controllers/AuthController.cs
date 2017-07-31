using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExample.Web.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ViewResult Login()
        {
            return View();
        }
    }
}