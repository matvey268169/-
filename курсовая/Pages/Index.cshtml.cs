using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace курсовая.Pages
{
    public class IndexModel : PageModel
    {
        // Пример списка книг (замените на данные из базы данных)
        public List<Book> Books { get; set; } = new List<Book>
        {
            // Книги жанра "Фантастика"
            new Book { Title = "1984", Author = "Джордж Оруэлл", Year = 1949, Country = "Великобритания", Genre = "Фантастика" },
            new Book { Title = "О дивный новый мир", Author = "Олдос Хаксли", Year = 1932, Country = "Великобритания", Genre = "Фантастика" },
            new Book { Title = "451° по Фаренгейту", Author = "Рэй Брэдбери", Year = 1953, Country = "США", Genre = "Фантастика" },

            // Книги жанра "Детектив"
            new Book { Title = "Убийство в Восточном экспрессе", Author = "Агата Кристи", Year = 1934, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Шерлок Холмс: Собака Баскервилей", Author = "Артур Конан Дойл", Year = 1902, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Десять негритят", Author = "Агата Кристи", Year = 1939, Country = "Великобритания", Genre = "Детектив" },

            // Книги жанра "Роман"
            new Book { Title = "Война и мир", Author = "Лев Толстой", Year = 1869, Country = "Россия", Genre = "Роман" },
            new Book { Title = "Анна Каренина", Author = "Лев Толстой", Year = 1877, Country = "Россия", Genre = "Роман" },
            new Book { Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Year = 1967, Country = "Россия", Genre = "Роман" },

            // Книги жанра "Научная литература"
            new Book { Title = "Краткая история времени", Author = "Стивен Хокинг", Year = 1988, Country = "Великобритания", Genre = "Научная литература" },
            new Book { Title = "Происхождение видов", Author = "Чарльз Дарвин", Year = 1859, Country = "Великобритания", Genre = "Научная литература" },
            new Book { Title = "Космос", Author = "Карл Саган", Year = 1980, Country = "США", Genre = "Научная литература" },

            // Книги автора "Лев Толстой"
            new Book { Title = "Война и мир", Author = "Лев Толстой", Year = 1869, Country = "Россия", Genre = "Роман" },
            new Book { Title = "Анна Каренина", Author = "Лев Толстой", Year = 1877, Country = "Россия", Genre = "Роман" },
            new Book { Title = "Смерть Ивана Ильича", Author = "Лев Толстой", Year = 1886, Country = "Россия", Genre = "Роман" },

            // Книги автора "Джордж Оруэлл"
            new Book { Title = "1984", Author = "Джордж Оруэлл", Year = 1949, Country = "Великобритания", Genre = "Фантастика" },
            new Book { Title = "Скотный двор", Author = "Джордж Оруэлл", Year = 1945, Country = "Великобритания", Genre = "Фантастика" },
            new Book { Title = "Дни в Бирме", Author = "Джордж Оруэлл", Year = 1934, Country = "Великобритания", Genre = "Роман" },

            // Книги автора "Михаил Булгаков"
            new Book { Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Year = 1967, Country = "Россия", Genre = "Роман" },
            new Book { Title = "Собачье сердце", Author = "Михаил Булгаков", Year = 1925, Country = "Россия", Genre = "Фантастика" },
            new Book { Title = "Белая гвардия", Author = "Михаил Булгаков", Year = 1926, Country = "Россия", Genre = "Роман" },

            // Книги автора "Агата Кристи"
            new Book { Title = "Убийство в Восточном экспрессе", Author = "Агата Кристи", Year = 1934, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Десять негритят", Author = "Агата Кристи", Year = 1939, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Убийство Роджера Экройда", Author = "Агата Кристи", Year = 1926, Country = "Великобритания", Genre = "Детектив" },

            // Книги 2020 года
            new Book { Title = "Книга 2020 года 1", Author = "Автор 1", Year = 2020, Country = "США", Genre = "Фантастика" },
            new Book { Title = "Книга 2020 года 2", Author = "Автор 2", Year = 2020, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Книга 2020 года 3", Author = "Автор 3", Year = 2020, Country = "Россия", Genre = "Роман" },

            // Книги 2010 года
            new Book { Title = "Книга 2010 года 1", Author = "Автор 1", Year = 2010, Country = "США", Genre = "Фантастика" },
            new Book { Title = "Книга 2010 года 2", Author = "Автор 2", Year = 2010, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Книга 2010 года 3", Author = "Автор 3", Year = 2010, Country = "Россия", Genre = "Роман" },

            // Книги 2000 года
            new Book { Title = "Книга 2000 года 1", Author = "Автор 1", Year = 2000, Country = "США", Genre = "Фантастика" },
            new Book { Title = "Книга 2000 года 2", Author = "Автор 2", Year = 2000, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Книга 2000 года 3", Author = "Автор 3", Year = 2000, Country = "Россия", Genre = "Роман" },

            // Книги 1990 года
            new Book { Title = "Книга 1990 года 1", Author = "Автор 1", Year = 1990, Country = "США", Genre = "Фантастика" },
            new Book { Title = "Книга 1990 года 2", Author = "Автор 2", Year = 1990, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Книга 1990 года 3", Author = "Автор 3", Year = 1990, Country = "Россия", Genre = "Роман" },

            // Книги из России
            new Book { Title = "Война и мир", Author = "Лев Толстой", Year = 1869, Country = "Россия", Genre = "Роман" },
            new Book { Title = "Анна Каренина", Author = "Лев Толстой", Year = 1877, Country = "Россия", Genre = "Роман" },
            new Book { Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Year = 1967, Country = "Россия", Genre = "Роман" },

            // Книги из США
            new Book { Title = "451° по Фаренгейту", Author = "Рэй Брэдбери", Year = 1953, Country = "США", Genre = "Фантастика" },
            new Book { Title = "Космос", Author = "Карл Саган", Year = 1980, Country = "США", Genre = "Научная литература" },
            new Book { Title = "Книга 2020 года 1", Author = "Автор 1", Year = 2020, Country = "США", Genre = "Фантастика" },

            // Книги из Великобритании
            new Book { Title = "1984", Author = "Джордж Оруэлл", Year = 1949, Country = "Великобритания", Genre = "Фантастика" },
            new Book { Title = "Убийство в Восточном экспрессе", Author = "Агата Кристи", Year = 1934, Country = "Великобритания", Genre = "Детектив" },
            new Book { Title = "Краткая история времени", Author = "Стивен Хокинг", Year = 1988, Country = "Великобритания", Genre = "Научная литература" },

            // Книги из Франции
            new Book { Title = "Граф Монте-Кристо", Author = "Александр Дюма", Year = 1844, Country = "Франция", Genre = "Роман" },
            new Book { Title = "Три мушкетера", Author = "Александр Дюма", Year = 1844, Country = "Франция", Genre = "Роман" },
            new Book { Title = "Отверженные", Author = "Виктор Гюго", Year = 1862, Country = "Франция", Genre = "Роман" }
        };

        // Отфильтрованные книги
        public List<Book> FilteredBooks { get; set; } = new List<Book>();

        // Параметры фильтрации
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Author { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? Year { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Country { get; set; }

        public void OnGet()
        {
            // Фильтрация книг
            FilteredBooks = Books;

            if (!string.IsNullOrEmpty(Genre))
            {
                FilteredBooks = FilteredBooks.Where(b => b.Genre == Genre).ToList();
            }

            if (!string.IsNullOrEmpty(Author))
            {
                FilteredBooks = FilteredBooks.Where(b => b.Author == Author).ToList();
            }

            if (Year.HasValue)
            {
                FilteredBooks = FilteredBooks.Where(b => b.Year == Year).ToList();
            }

            if (!string.IsNullOrEmpty(Country))
            {
                FilteredBooks = FilteredBooks.Where(b => b.Country == Country).ToList();
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
    }
}