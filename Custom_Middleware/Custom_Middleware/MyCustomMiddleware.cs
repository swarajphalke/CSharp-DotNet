public class MyCustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("Inside MyMiddleware (Before next)\n");
        await next(context);
        await context.Response.WriteAsync("Inside MyMiddleware (After next)\n");
    }
}