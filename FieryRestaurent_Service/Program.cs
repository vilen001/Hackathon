using FieryRestaurent.Dal.DataBase;
using FieryRestaurent.Dal.RepositoryImpl;
using FieryRestaurent.Entity.Repository;
using FieryRestaurent.LoggingService;
using FieryRestaurent.ServiceLayer.Mapping;
using FieryRestaurent.ServiceLayer.SupplierService;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.Ini;
using Microsoft.Extensions.Options;
using NLog;

namespace FieryRestaurent_Service
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            // Add services to the container.

            // Register to DI

            builder.Services.AddScoped<ILoggerManager, LoggerManager>();
            builder.Services.AddScoped<ISupplierRepository, SupplierRepositoryImpl>();
            builder.Services.AddScoped<ISupplierService, SupplierServiceImpl>();
            builder.Services.AddAutoMapper(typeof(SupplierDtoHelper).Assembly);
            builder.Services.AddDbContext<SupplierDbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("SupplierDb")));
            builder.Services.AddMemoryCache();

            builder.Services.AddControllers().AddNewtonsoftJson();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddOData();

            //CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Supplier",
                policy =>
                {
                    policy.WithOrigins("https://localhost:44322/swagger/index.html").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });
            });

          //  builder.Services.AddResponseCaching(x => x.MaximumBodySize = 1024);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            //  app.MapControllers();
            app.UseRouting();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.EnableDependencyInjection();
                endpoints.Select().OrderBy().Filter().MaxTop(100).SkipToken();
                endpoints.MapControllers();
            });

            //app.UseResponseCaching();
            //app.Use(async (context, next) =>
            //{
            //    context.Response.GetTypedHeaders().CacheControl =
            //    new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
            //    {
            //        Public = true,
            //        MaxAge = TimeSpan.FromSeconds(10)
            //    };
            //    context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] = new string[] { "Accept-Encoding" };
            //    await next();
            //});

         

            app.Run();
        }
    }
}