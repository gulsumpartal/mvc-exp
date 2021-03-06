﻿using System.Text;
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

        public PartialViewResult Display()
        {
            return PartialView("Display");
        }
        [HttpPost]
        public PartialViewResult AddNewsModalDisplay()
        {
            return PartialView("_AddNewsPartial");
        }
    }
}