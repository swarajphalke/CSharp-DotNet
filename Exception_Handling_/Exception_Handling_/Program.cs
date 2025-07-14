var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ------------- EXCEPTION HANDLING CONFIGURATION -------------

// If in the Development Environment:
if (app.Environment.IsDevelopment())
{
    // The Developer Exception Page will display detailed errors.
    app.UseDeveloperExceptionPage();
}
// If in Production, Staging, or any other environment:
else
{
    // The application will redirect to the specified path (/Home/Error) 
    // when an unhandled exception occurs.
    app.UseExceptionHandler("/Home/Error");

    // Optional: Add HSTS for security in production
    app.UseHsts();
}
// --------------------------------------

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
