using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcTutorials.Controllers
{
    public class PartialViewExampleController : Controller
    {
        // GET: PartialViewExample
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuPartial()
        {
            var data = new List<MenuItem>();
            data.Add(new MenuItem() { Title = "Microsoft", Link = "http://www.microsoft.com" });
            data.Add(new MenuItem() { Title = "Google", Link = "http://www.google.com" });
            data.Add(new MenuItem() { Title = "IBM", Link = "http://www.ibm.com" });
            data.Add(new MenuItem() { Title = "Oracle", Link = "http://www.oracle.com" });


            return PartialView("_MenuWithDataModelPartial", data);
        }
    }

    public class MenuItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}