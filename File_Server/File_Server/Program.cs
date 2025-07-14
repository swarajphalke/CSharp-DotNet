using Microsoft.Extensions.Options;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

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
//app.UseStaticFiles();

//creating a new object named obj to customize how files are served in your project.
FileServerOptions obj = new FileServerOptions();
//Remove all the default file names (like default.html, index.htm, etc.)
obj.DefaultFilesOptions.DefaultFileNames.Clear();
//Added new static file
obj.DefaultFilesOptions.DefaultFileNames.Add("index.html");
app.UseFileServer(obj); // This does: UseDefaultFiles + UseStaticFiles(+optional directory browsing)

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
