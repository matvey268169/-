using System;
namespace курсовая.Models
{
    public class BorrowedBook
    {
        public string Title { get; set; } // Название книги
        public string Author { get; set; } // Автор книги
        public DateTime BorrowDate { get; set; } // Дата взятия книги
        public DateTime? ReturnDate { get; set; } // Дата возврата книги (может быть null, если книга еще не возвращена)
    }
}
