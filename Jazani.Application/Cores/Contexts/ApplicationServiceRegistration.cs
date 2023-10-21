using Jazani.Application.Admins.Services;
using Jazani.Application.Admins.Services.Implementations;
using Jazani.Application.Generals.Services;
using Jazani.Application.Generals.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Jazani.Application.Cores.Contexts
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //La clase "ApplicationAutofacModule" ya lo implementa :
            //services.AddTransient<IOfficeService, OfficeService>();
            //services.AddTransient<IMineralTypeService, MineralTypeService>();

            return services;
        }
    }
}
