namespace SteelDonkey.WebApi.Configurations
{
    public static class MiddlewareConfig
    {
        public static async Task<IApplicationBuilder> UseAppMiddleware(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseShowAllServicesMiddleware();
            }
            else
            {
                app.UseDefaultExceptionHandler();
                app.UseHsts();
            }

            app.UseFastEndpoints()
                .UseSwaggerGen();

            app.UseHttpsRedirection();

            return app;
        }
    }
}
