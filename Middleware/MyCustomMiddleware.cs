namespace WebApplication1.Middleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hii From Custom Middleware");
            await next(context);
        }
    }
}
