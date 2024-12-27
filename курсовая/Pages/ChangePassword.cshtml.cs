using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace курсовая.Pages
{
    public class ChangePasswordModel : PageModel
    {
        [BindProperty]
        public string CurrentPassword { get; set; }

        [BindProperty]
        public string NewPassword { get; set; }

        [BindProperty]
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            
            if (NewPassword != ConfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Новый пароль и подтверждение пароля не совпадают.");
                return Page();
            }

            
            if (IsPasswordChanged(CurrentPassword, NewPassword))
            {
                
                TempData["SuccessMessage"] = "Пароль успешно изменен.";

                
                return RedirectToPage("/Account");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ошибка изменения пароля. Пожалуйста, попробуйте снова.");
                return Page();
            }
        }

        private bool IsPasswordChanged(string currentPassword, string newPassword)
        {
           
            return !string.IsNullOrEmpty(currentPassword) && !string.IsNullOrEmpty(newPassword);
        }
    }
}