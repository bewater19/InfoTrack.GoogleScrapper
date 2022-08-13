using GoogleScrapper.Domain.Interfaces;
using GoogleScrapper.Domain.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddGoogleScrapperApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            //service
            services.AddScoped<ISearchService, SearchService>();

            return services;
        }
    }
}
