using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web1.Pages
{
    public class Test05Model : PageModel
    {
        public List<string> ServerVariableItems { get; set; }

        public void OnGet()
        {
            ServerVariableItems = new List<string>();

            foreach (var item in HttpContext.Request.Headers)
            {
                ServerVariableItems.Add($"{item.Key} : {item.Value} ");
            }
        }
    }
}
