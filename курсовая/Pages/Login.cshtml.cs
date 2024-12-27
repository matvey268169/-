using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace курсовая.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Login { get; set; } // E-mail или номер телефона

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
            // Логика для обработки GET-запросов
        }

        public IActionResult OnPost()
        {
            // Логика для обработки POST-запросов (например, проверка данных)
            if (IsValidUser(Login, Password))
            {
                // Перенаправление на главную страницу после успешного входа
                return RedirectToPage("/Index");
            }
            else
            {
                // Ошибка входа
                ModelState.AddModelError(string.Empty, "Неверный E-mail, номер телефона или пароль.");
                return Page();
            }
        }

        private bool IsValidUser(string login, string password)
        {
            // Здесь должна быть логика проверки пользователя (например, запрос к базе данных)
            // Это пример, замените его на реальную проверку
            return (login == "user@example.com" || login == "+1234567890") && password == "password123";
        }
    }
}