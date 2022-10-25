using Emobile_Task.DAL.Data;
using Emobile_Task.DAL.Repositories.Abstractions;
using Emobile_Task.DAL.Repositories.Concretes;
using Emobile_Task.DAL.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.DAL.Extentions
{
    public static class DataLayerExtentions
    {
        public static IServiceCollection LoadDataLayerExtentions(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<EmobileTaskContext>(option => option.UseSqlServer(config.GetConnectionString("DBConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
