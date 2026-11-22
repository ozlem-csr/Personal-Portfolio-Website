 
using KisiselSayfam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;


var builder = WebApplication.CreateBuilder(args);

// DbContext -> en önemli kısım burası
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


// 🔹 Session ekledik (eklenen)
builder.Services.AddSession();

var app = builder.Build();

// Exception & HSTS
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


// 🔹 Session middleware (eklenen)
app.UseSession();

app.UseAuthorization();

// Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
