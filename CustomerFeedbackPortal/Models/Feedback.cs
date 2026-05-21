using System.ComponentModel.DataAnnotations;

namespace CustomerFeedbackPortal.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        public string Comments { get; set; }
    }
}