namespace MVCass1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            #region demo1
            // app.Use(async (context, next) =>
            // {
            //     Endpoint endpoint = context.GetEndpoint();
            //     if (endpoint is null)
            //     {
            //         await context.Response.WriteAsync("ur request page not found");
            //     }
            //     await next();
            // });

            //app.UseEndpoints(endpoints => 
            // {
            //     endpoints.MapGet("/Home", async context =>
            //     {
            //         await context.Response.WriteAsync("U are at home page");
            //     });
            //     endpoints.MapGet("/Products", async context =>
            //     {
            //         await context.Response.WriteAsync("U are at product page");
            //     });
            //     endpoints.MapGet("/Products/{Id}", async context =>
            //     {
            //         int id =Convert.ToInt32(context.Request.RouteValues["Id"]);
            //         await context.Response.WriteAsync($"ur reqest for the prodcut id => {id}");
            //     });
            //     endpoints.MapGet("/Book/{Id}/{auther}", async context =>
            //     {
            //         int id = Convert.ToInt32(context.Request.RouteValues["Id"]);
            //         string auther = context.Request.RouteValues["auther"].ToString();
            //         await context.Response.WriteAsync($"ur reqest for the book id => {id} and auther => {auther}");
            //     });


            // });
            #endregion
            app.MapControllerRoute(
               name: "default",
               pattern: "/{controller=Home}/{action=Index}" ,
               defaults: new { controller = "Home", action = "Index" });

            app.Run();

        }
    }
}
