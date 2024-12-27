using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace курсовая.Pages
{
    public class ConfirmDeleteModel : PageModel
    {
        public void OnGet()
        {
            // Логика для обработки GET-запросов
        }

        public IActionResult OnPostDelete()
        {
            // Логика удаления аккаунта (например, удаление из базы данных)
            // Это пример, замените его на реальную логику
            if (DeleteAccount())
            {
                TempData["SuccessMessage"] = "Аккаунт успешно удален.";
                return RedirectToPage("/Index");
            }
            else
            {
                TempData["ErrorMessage"] = "Ошибка удаления аккаунта. Пожалуйста, попробуйте снова.";
                return RedirectToPage("/Account");
            }
        }

        private bool DeleteAccount()
        {
            // Здесь должна быть логика удаления аккаунта
            // Это пример, замените его на реальную проверку
            return true;
        }
    }
}