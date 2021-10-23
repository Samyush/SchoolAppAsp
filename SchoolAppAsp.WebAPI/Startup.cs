using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SchoolAppASP.Application.Handlers;
using SchoolAppASP.Infastructure;
using SchoolAppASP.Infastructure.Data;
using SchoolAppASP.Infastructure.Repositories;
using MediatR;
using System.Reflection;

namespace SchoolAppAsp.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<UserContext>(m => m.UseSqlServer(Configuration.GetConnectionString("UserDB")), ServiceLifetime.Singleton);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SchoolApps", Version = "v1" });
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddMediatR(typeof(CreateUserHandler).GetTypeInfo().Assembly);

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IUserRepository, UserRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();

                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SchoolApps v1"));

            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
