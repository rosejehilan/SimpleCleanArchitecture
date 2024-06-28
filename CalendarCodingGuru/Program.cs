using Infrastructure.Data;
using Application.Services;
using Domain.Repositories ;
using Infrastructure.Data;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CalendarDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CalendarDB") ??
    throw new InvalidOperationException("Connection string 'BlogBbContext' not found.")));

builder.Services.AddTransient<ICalendarDayRepository, CalendarDay>();
builder.Services.AddTransient<ICalendarDayServices, CalendarDayService>();
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
