using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace курсовая.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Phone { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
            // Логика для обработки GET-запросов
        }

        public IActionResult OnPost()
        {
            // Логика для обработки POST-запросов (например, регистрация пользователя)
            if (Password != ConfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Пароли не совпадают.");
                return Page();
            }

            // Здесь должна быть логика регистрации пользователя (например, сохранение в базе данных)
            // Это пример, замените его на реальную логику
            if (IsValidRegistration(Username, Email, Phone, Password))
            {
                // Перенаправление на страницу входа после успешной регистрации
                return RedirectToPage("/Login");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ошибка регистрации. Пожалуйста, попробуйте снова.");
                return Page();
            }
        }

        private bool IsValidRegistration(string username, string email, string phone, string password)
        {
            // Здесь должна быть логика проверки и регистрации пользователя
            // Это пример, замените его на реальную проверку
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(password);
        }
    }
}
