using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedbackPortal.Helpers
{
    public static class CustomHtmlHelpers
    {
        // Custom HTML Helper for styled input field
        public static IHtmlContent StyledInput(
            this IHtmlHelper htmlHelper,
            string name,
            string placeholder)
        {
            string html =
                $"<input type='text' name='{name}' placeholder='{placeholder}' class='form-control mb-3' />";

            return new HtmlString(html);
        }
    }
}