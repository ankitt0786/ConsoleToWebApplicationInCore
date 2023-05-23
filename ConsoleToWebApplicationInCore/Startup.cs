namespace ConsoleToWebApplicationInCore
{
    public class Startup
    {
        //this method is use to setup our dependencies
        public void ConfigureServices(IServiceCollection services)
        {
            //use to set up the dependencies like mvc or api or razor pages

            services.AddControllersWithViews();


            //for runtime debugging while development environment
            //before add this we have to add nuget package razor.runtimecompiler

#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
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

            //for static files in wwwroot
            app.UseStaticFiles();

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
