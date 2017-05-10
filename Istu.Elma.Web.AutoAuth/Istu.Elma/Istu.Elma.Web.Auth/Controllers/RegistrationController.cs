using Istu.Elma.Web.Auth.Models;
using Istu.Elma.Auth.Repository;
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

            
            var test = new AuthRepository();
            test.CreateElmaTask("Шонбина Яна Сергеевна","sloona@mail.ru");
            return View("Reply");
        }
    }
}