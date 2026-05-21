using CustomerFeedbackPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerFeedbackPortal.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbacks =
            new List<Feedback>();

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbacks.Add(feedback);

                return RedirectToAction("List");
            }

            return View(feedback);
        }

        public IActionResult List()
        {
            return View(feedbacks);
        }
    }
}