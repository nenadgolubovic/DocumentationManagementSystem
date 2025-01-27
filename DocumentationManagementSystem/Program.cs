using DMS.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DMS.Utilities;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Humanizer;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser,IdentityRole>().
    AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

//Initialize data 
void DataSedding() 
{
    //Create scope - resourse which is not used are automatically released after the method completes.
    using (var scope = app.Services.CreateScope())
    {
        
        var dbInitializer = scope.ServiceProvider.
            //Get from IDbInitializer
            GetRequiredService<IDbInitializer>();
        dbInitializer.Initialize();

    }
}

