using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//using OnlineShop.Domain.Models.Aggregates.ProductAggregates;
using OnlineShop.Infrastructure;
using OnlineShop.Infrastructure.Contracts;
using OnlineShop.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddScoped<IproductRepository, ProductRepository>();

// add swagger to you'r project using this link
// https://medium.com/@jasminewith/adding-swagger-to-asp-net-core-mvc-web-api-project-263473ea02a8


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
