using Copernicus.Christian.Api.Helpers;
using Copernicus.Christian.Domain.Interfaces;
using Copernicus.Christian.Infrastructure.Repositories;
using MediatR;
using System.Reflection;

namespace Copernicus.Christian.Api.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
