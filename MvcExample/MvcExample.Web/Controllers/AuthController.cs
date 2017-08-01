using System.Web.Mvc;
using MvcExample.Core.Services.User;
using MvcExample.DTO.User;
using MvcExample.Common.Helpers;

namespace MvcExample.Web.Controllers
{
    public class AuthController : Controller
    {

        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Login(UserLoginDto dto)
        {
            var userData = new UserService().GetuserDetail(dto);

            if (userData == null)
                return Json("ERROR");

            UserHelper.CurrentUser = userData;
            return Json("Ok");
        }
        [HttpPost]
        public JsonResult Logout()
        {
            UserHelper.CurrentUser = null;
            return Json("OK");
        }
        

    }
}