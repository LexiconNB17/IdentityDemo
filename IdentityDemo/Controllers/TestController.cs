using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityDemo.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            ViewBag.Title = "Admin";
            return View("Index");
        }

        [AllowAnonymous]
        public ActionResult Public()
        {
            ViewBag.Title = "Public";
            return View("Index");
        }

        [Authorize(Roles = "Editor")]
        public ActionResult Editor()
        {
            ViewBag.Title = "Editor";
            return View("Index");
        }

        [Authorize(Roles = "Editor, Admin")]
        public ActionResult AdminOrEditor()
        {
            ViewBag.Title = "AdminOrEditor";
            return View("Index");
        }

        [Authorize(Roles = "Editor")]
        [Authorize(Roles = "Admin")]
        public ActionResult AdminAndEditor()
        {
            ViewBag.Title = "AdminAndEditor";
            return View("Index");
        }

        [Authorize(Users = "user@lexicon.se")]
        public ActionResult UserIdentity()
        {
            ViewBag.Title = "User";
            return View("Index");
        }



    }
}