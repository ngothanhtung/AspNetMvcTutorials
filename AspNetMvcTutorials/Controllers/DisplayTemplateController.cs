using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcTutorials.Models;

namespace AspNetMvcTutorials.Controllers
{
    public class DisplayTemplateController : Controller
    {
        // GET: DisplayTemplate
        public ActionResult Index()
        {
            var user = new User
            {
                ID = 1,
                UserName = "tungnt",
                FirstName = "Ngô",
                LastName = "Tùng",
                MiddleInitial = "",
                DateOfBirth = new DateTime(1980, 4, 10),
                IsAdmin = true

            };

            return View(user);
        }
    }
}