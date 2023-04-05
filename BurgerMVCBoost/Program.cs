using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.EntityLayer.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BurgerDbContext>();
builder.Services.AddIdentity<AppUser, AppRole>(
    opt =>
    {
        opt.Password.RequiredLength = 3;
        opt.Password.RequireUppercase = false;
        opt.Password.RequireLowercase = false;
        opt.Password.RequireNonAlphanumeric = false;
    }
    ).AddRoles<AppRole>().AddEntityFrameworkStores<BurgerDbContext>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAuthentication().AddFacebook(x =>
{
    x.AppId = builder.Configuration["FacebookAppId"];
    x.AppSecret = builder.Configuration["FacebookAppSecret"];
});

builder.Services.AddAuthentication().AddGoogle(x =>
{
    x.ClientId = builder.Configuration["web:client_id"];
    x.ClientSecret = builder.Configuration["web:client_secret"];
});

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
app.UseAuthentication();
app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Menu}/{action=Index}/{id?}"
        );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
