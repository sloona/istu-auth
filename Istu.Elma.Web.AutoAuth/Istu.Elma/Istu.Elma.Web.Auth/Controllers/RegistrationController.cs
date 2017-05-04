using Istu.Elma.Web.Auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Istu.Elma.Web.Auth.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View("Registration");
        }

        public ActionResult CreateElmaTask(AuthModel model)
        {
            if (!ModelState.IsValid)
            {
                //ViewBag.Error = "Неправильно заполнены данные";
                return View("Registration", model);
            }
            return View("Reply");
        }
    }
}