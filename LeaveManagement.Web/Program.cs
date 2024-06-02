using LeaveManagement.Application.Configurations;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.Repositories;
using LeaveManagement.Data;
using LeaveManagement.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace LeaveManagement.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddTransient<IEmailSender>(s => new EmailSender("localhost", 25, "no-reply@leavemanagement.com"));

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            builder.Services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
            builder.Services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();

            builder.Services.AddAutoMapper(typeof(MapperConfig));

            builder.Host.UseSerilog((ctx, lc) =>
                lc.WriteTo.Console()
                .ReadFrom.Configuration(ctx.Configuration));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseSerilogRequestLogging();

            app.UseDeveloperExceptionPage();
            app.UseMigrationsEndPoint();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}