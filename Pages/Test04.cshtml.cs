using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web1.Pages
{
    public class Test04Model : PageModel
    {
        public string[] MyArray = { "c" , "c++", "java", "asp", "python" , "php", "asp.net" };
        public void OnGet()
        {
        }
    }
}
