﻿using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Menu.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
