using GoogleScrapper.Domain.Interfaces;
using GoogleScrapper.Infrastructure.Persistance;
using GoogleScrapper.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddGoogleScrapperInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
            //Repo
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ISearchRepository, SearchRepository>();


            return services;
        }
    }
}
