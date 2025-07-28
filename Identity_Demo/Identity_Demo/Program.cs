using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Identity_Demo.Data;
using Identity_Demo.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Identity_DemoContextConnection") ?? throw new InvalidOperationException("Connection string 'Identity_DemoContextConnection' not found.");

builder.Services.AddDbContext<Identity_DemoContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Identity_DemoUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Identity_DemoContext>();

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
app.MapRazorPages();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
