using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcTutorials.Controllers
{
    public class ActionResultExampleController : Controller
    {
        // GET: Session02
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var data = new List<Employee>();
            data.Add(new Employee() { Id = 1, Name = "Peter" });
            data.Add(new Employee() { Id = 2, Name = "John" });
            data.Add(new Employee() { Id = 3, Name = "Mary" });
            data.Add(new Employee() { Id = 4, Name = "Paul" });

            return View(data);
        }

        public ActionResult Find(int? id)
        {
            var data = new List<Employee>();
            data.Add(new Employee() { Id = 0, Name = "Zero" });
            data.Add(new Employee() { Id = 1, Name = "Peter" });
            data.Add(new Employee() { Id = 2, Name = "John" });
            data.Add(new Employee() { Id = 3, Name = "Mary" });
            data.Add(new Employee() { Id = 4, Name = "Paul" });


            if (id.HasValue)
            {
                return View(data[id.Value]);
            }

            return View(data[0]);
        }

        // PartialViewResult
        // Description: Renders a partial view, which is a sub-view of the main view
        // Description: Renders a specifed partial view to the response stream
        // Usage: @Html.Action("PartialViewResultSample", "Session02")
        public PartialViewResult PartialViewResultSample()
        {
            return PartialView("_MenuPartial", new[] { "C#", "JAVA" }); // pass DataModel to PartialPage
            //return PartialView("_MenuPartial", null);
        }

        public ActionResult EmptyResultExample()
        {
            return new EmptyResult();
        }

        // RedirectResult
        public ActionResult RedirectResultExample()
        {
            return Redirect("http://www.google.com");
            //return new RedirectResult("http://www.google.com");
        }

        // RedirectResult
        public ActionResult JsonResultExample()
        {
            var data = new List<Employee>();
            data.Add(new Employee() { Id = 1, Name = "Peter" });
            data.Add(new Employee() { Id = 2, Name = "John" });
            data.Add(new Employee() { Id = 3, Name = "Mary" });
            data.Add(new Employee() { Id = 4, Name = "Paul" });
            return Json(data, JsonRequestBehavior.AllowGet);

        }
    }

    public class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
    }
}