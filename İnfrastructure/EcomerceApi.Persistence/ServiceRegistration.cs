using EcomerceApi.Persistence.Concretes;
using EcomerceApi.Persistence.Context;
using EcommerceApi.Application.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services )
        {
            services.AddSingleton<IProductService, ProductService>();

            services.AddDbContext<EcommerceDbContext>(options =>options.UseSqlServer("DefaultConnection"));
        }

    }
}
