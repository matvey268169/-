using Microsoft.EntityFrameworkCore;
using курсовая.Data;

var builder = WebApplication.CreateBuilder(args);

// Добавление сервисов в контейнер
builder.Services.AddRazorPages(); // Для Razor Pages
builder.Services.AddControllersWithViews(); // Для MVC (если нужно)

// Настройка контекста базы данных (если используется)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Настройка конвейера HTTP-запросов
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error"); // Для Razor Pages
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages(); // Для Razor Pages
app.MapControllerRoute( // Для MVC (если нужно)
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();