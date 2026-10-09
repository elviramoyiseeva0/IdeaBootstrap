using Feedback.Models;
using Feedback.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Feedback.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View(new FeedbackViewModel());
        }

        [HttpPost]
        public IActionResult Contact(FeedbackViewModel model)
        {
            string result = $"Message successfully sent to administrator!\nSubject: {model.Subject}\nEmail: {model.Email}\nMessage: {model.Message}";
            return Content(result);
        }
    }
}
