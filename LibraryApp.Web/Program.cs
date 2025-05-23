using LibraryApp.Web.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<BookService>();
builder.Services.AddSingleton<IBookService, BookService>();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();

app.Run();
