using BigonApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("cString");

builder.Services.AddDbContext<DataContext>(x =>
{
    x.UseSqlServer(connectionString);
});



var app = builder.Build();



app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
