using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcExample.Core.Services.News;
using MvcExample.DTO.News;

namespace MvcExample.Web.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Add(NewsDto dto)
        {
            //servisten ekleme işlemini çağırmam lazım
            var response = new NewsService().Add(dto);
            if (response)
            {
                return Json("ok");
            }
            return Json("error");
        }
        public PartialViewResult AddNewsPartial()
        {
            //burada servisi halletmem lazım
            var model = new NewsService().GetNewses();
            return PartialView("_AddNewsPartial",model);
        }
    }
}