using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web1.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Id { get; set; }
        [BindProperty]
        public string Pass { get; set; }



        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(Id == "test" && Pass == "1111")
            {
                TempData["ErrorMessage"] = "�ݰ����ϴ�.~~~";
                TempData["NextPage"] = "/";
                return RedirectToPage("Success");
            }else
            {
                TempData["ErrorMessage"] = "���̵�� ��й�ȣ�� �Է��ϼ���";
                TempData["NextPage"] = "/Login";
                return RedirectToPage("Failure");
            }
        }

        /*
        public void OnPost()
        {
            string id = Request.Form["id"];
            string pass = Request.Form["Pass"];

            if(id == "test" && pass == "1111" )
            {

            }
        }
        */
    }
}
