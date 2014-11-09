using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class HomeController : Controller
    {
        private BlogDBContext db = new BlogDBContext();

        public ActionResult Index()
        {
            var posts = db.Posts.ToList();

            return View(posts);
        }

        public ActionResult Authors()
        {
            var authors = db.Users.ToList();

            return View(authors);
        }
    }
}