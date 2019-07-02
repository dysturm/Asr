using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Recruiters()
        {
            ViewBag.Message = "Add New Recruiter";

            return View();
        }

        [HttpPost]
        public ActionResult Recruiters(ASR_RECRUITERS model)
        {
            if (ModelState.IsValid)
            {
                var db = new TransferredEntities1();
                var recruiter = db.Submissions.FirstOrDefault(c => c.SLNO == 118).ASR_RECRUITERS;



                //newPerson.Id = db.TestTables.Max(c => c.Id) + 1;
                //newPerson.FirstName = model.FirstName;
                //newPerson.LastName = model.LastName;
                //db.TestTables.Add(newPerson);
                //db.SaveChanges();
                //ModelState.Clear();
            }
            return View();
        }

        [HttpGet]
        public ActionResult Recruiters(int? val)
        {
            ViewBag.Message = val;
            return View();
        }

        public ActionResult Consultants()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}