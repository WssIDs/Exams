using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using questions.DAL;

namespace question_13.Controllers
{
    public class HomeController : Controller
    {

        List<Comment> comments = new List<Comment>
        {
            new Comment {CommentId = 1, Name = "Виталий", date = DateTime.Now, message = "Привет мир!"},
           new Comment {CommentId = 2, Name = "Ольга", date = DateTime.Now, message = "Привет мир 2!"}
        };

        public ActionResult Index()
        {
            return View(comments);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public ActionResult AddComment()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult AddComment(Comment comment)
        {
            comments.Add(comment);
            return RedirectToAction("Index");
        }
    }
}