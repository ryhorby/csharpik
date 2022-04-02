using csharpik.Data.BookProjectData;
using csharpik.Repositories;
using csharpik.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DbSet
string connectionString = builder.Configuration["DefaultConnection"];

builder.Services.AddDbContext<BookProjectContext>(
    options => options.UseSqlServer(connectionString)
    );

builder.Services.AddScoped<BookRepository>();
builder.Services.AddScoped<BookService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error/");
    
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();