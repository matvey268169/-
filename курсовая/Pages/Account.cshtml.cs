using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using курсовая.Models;

namespace курсовая.Pages
{
    public class AccountModel : PageModel
    {
        // Добавьте это свойство
        public List<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();

        public void OnGet()
        {
            // Пример данных (замените на реальные данные из базы данных)
            BorrowedBooks = new List<BorrowedBook>
            {
                new BorrowedBook { Title = "Война и мир", Author = "Лев Толстой", BorrowDate = new DateTime(2024, 1, 1), ReturnDate = new DateTime(2024, 1, 15) },
                new BorrowedBook { Title = "1984", Author = "Джордж Оруэлл", BorrowDate = new DateTime(2024, 2, 1), ReturnDate = null }, // Книга еще не возвращена
                new BorrowedBook { Title = "Мастер и Маргарита", Author = "Михаил Булгаков", BorrowDate = new DateTime(2024, 3, 1), ReturnDate = new DateTime(2024, 3, 10) }
            };
        }
    }
}