﻿using Istu.Elma.Web.Auth.Models;
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
            ViewBag.Controller = "Registration";
            return View("Registration");
        }

        public ActionResult CreateElmaTask(AuthModel model)
        {
            if (!ModelState.IsValid)
            {
                //ViewBag.Error = "Неправильно заполнены данные";
                return View("Registration", model);
            }
 
            var repository = new AuthRepository();

            var modelAuth = repository.Create();
            modelAuth.FullName = model.FullName;
            modelAuth.Email = model.Email;
            modelAuth.Token = "16040229-1144-42b7-9dff-33e1c03c01f3";
            modelAuth.InstanceName = "Реквизиты доступа к системе Элма";

            var reply = repository.CreateElmaTask(modelAuth);

            return View("Reply", reply);
        }
    }
}