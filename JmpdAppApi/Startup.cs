using JmpdAppApi.DataAccess;
using JmpdAppApi.DataAccess.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace JmpdAppApi
{

    public class Startup
    {
        public Startup(IHostEnvironment env, IWebHostEnvironment webHost, IConfiguration configuration)
        {
            this.CurrentEnvironment = env;

            this.Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            this.Configuration.Bind("AppSettings", new AppSettings());
        }

        public IConfiguration Configuration { get; }

        public IHostEnvironment CurrentEnvironment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContextPool<IDatabaseContext, DatabaseContext>(
                            options =>
                            options.UseSqlServer(
                                AppSettings.ConnectionString,
                                opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)));

            services.AddSwaggerGen(x => x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "JmpdAppApi",
                Version = "v.1"
            }));

            services.AddHealthChecks();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHealthChecks("/hc");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            app.UseSwagger();
            app.UseSwaggerUI(c =>

            c.SwaggerEndpoint("../swagger/v1/swagger.json", "JmpdAppApi")
            );


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}