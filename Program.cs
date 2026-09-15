using Microsoft.EntityFrameworkCore;
using GetTheRepsWeb.Persistance.Data;

// initialize a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder class
// loads appsetting.json, environment variables, command-line args
// createbuilder(args) -> configure kestral defaults -> configure host (logging, config, di) -> return webappbuilder
var builder = WebApplication.CreateBuilder(args);

// register controllers
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        options.ViewLocationFormats.Add("~/Presentation/Views/{1}/{0}.cshtml");
        options.ViewLocationFormats.Add("~/Presentation/Views/Shared/{0}.cshtml");
    });

// register dbcontext (microsoft example: https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration )
var dbConnectionString =
    builder.Configuration.GetConnectionString("MSSQLConnection")
        ?? throw new InvalidOperationException("Connection String "
        + "'MSSQLConnection' not found in applicationsettings.json.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(dbConnectionString));

// register repositories


// register services


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
