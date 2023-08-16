using Microsoft.EntityFrameworkCore;
using NupatUNITOFWORK.Context;
using NupatUNITOFWORK.UnitOFWork.Implementation;
using NupatUNITOFWORK.UnitOFWork.Interface;

namespace NupatUNITOFWORK
{
    public static class ServiceExtension
    {
        public static void ConfigureConnectionString(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>
                (op => op.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
        public static void ConfigureInterface(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
