namespace ConsoleToWebApplicationInCore
{
    public class Startup
    {
        //this method is use to setup our dependencies
        public void ConfigureServices(IServiceCollection services)
        {
            //use to set up the dependencies like mvc or api or razor pages

            services.AddControllersWithViews();
        }

        //this method control the request pipeline with the help of middlewares
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //set up your development environment here
            //add all the middleware define here

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //this the default 

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello to your first application");
                //});

                endpoints.MapDefaultControllerRoute();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/ankit", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Ankit.");
            //    });
            //});
        }
    }
}
