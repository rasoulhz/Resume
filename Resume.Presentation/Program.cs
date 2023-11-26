using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Implement;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.appDbContext;
using Resume.Infrastructure.Repository;

namespace Resume.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(op =>
            op.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext")));

            builder.Services.AddScoped<IPersonalInformationService, PersonalInformationService>();
            builder.Services.AddScoped<IAboutMeService, AboutMeService>();

            builder.Services.AddScoped<IAllDTOsMappingService, AllDTOsMappingService>();

            builder.Services.AddScoped<IPersonalInformationRepository, PersonalInformationRepository>();
            builder.Services.AddScoped<IAboutMeRepository, AboutMeRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}