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

        public static List<Comment> comments = new List<Comment>
        {
            new Comment { CommentId = 1, Name = "Виталий", date = DateTime.Now, message = "Привет Мир!"}
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

        [HttpPost]
        public ActionResult AddComment(Comment comment)
        {
            comments.Add(comment);
            return View("Index",comments);
        }
    }
}