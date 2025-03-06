using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RandevuApp.Data;
using RandevuApp.Models;
using Microsoft.AspNetCore.Identity.UI;

var builder = WebApplication.CreateBuilder(args);

// MSSQL veritaban� ba�lant�s�
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity Kullan�c� Y�netimi
builder.Services.AddIdentity<RandevuApp.Data.ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
