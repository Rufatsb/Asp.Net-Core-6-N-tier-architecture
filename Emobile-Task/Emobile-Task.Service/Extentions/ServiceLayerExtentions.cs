using Emobile_Task.DAL.Data;
using Emobile_Task.DAL.Repositories.Abstractions;
using Emobile_Task.DAL.Repositories.Concretes;
using Emobile_Task.DAL.UnitOfWorks;
using Emobile_Task.Service.Services.Abstractions;
using Emobile_Task.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.Service.Extentions
{
    public static class ServiceLayerExtentions
    {
        public static IServiceCollection LoadServiceLayerExtentions(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ITravelService, TravelService>();
            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
