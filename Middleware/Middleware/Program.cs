using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Step 1: Register your middleware
builder.Services.AddTransient<MyMiddleware>();

var app = builder.Build();

// Step 2: Use the middleware
app.UseMiddleware<MyMiddleware>();

// ✅ Inline middleware
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware BEFORE next()\n");
    await next(); // Call the next middleware
    await context.Response.WriteAsync("Middleware AFTER next()\n");
});

// Optional: terminal middleware
app.Run(async context =>
{
    await context.Response.WriteAsync("End of request pipeline\n");
});

app.Run();



// Your middleware class (can also be in a separate file)
public class MyMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("Inside MyMiddleware (Before next)\n");
        await next(context);
        await context.Response.WriteAsync("Inside MyMiddleware (After next)\n");
    }
}
