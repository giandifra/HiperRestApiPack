﻿using HiperRestApiPack.EF;
using Microsoft.Extensions.DependencyInjection;

namespace HiperRestApiPack
{
    public static class ApiPackExtensions
    {
        public static IServiceCollection AddHiperApiPackEf(this IServiceCollection services)
        {
            services.AddTransient<IFilteredQuery, FilteredEfQuery>();
            return services;
        }
    }
}
