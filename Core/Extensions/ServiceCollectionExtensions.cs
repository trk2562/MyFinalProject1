using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    //Bu class core katmanı da dahil olmak üzere bütün injection'ları bir arada toplayabileceğimiz bir yapıdır.
    public static class ServiceCollectionExtensions
    {//this C#'ta genişletmek istediğin yer anlamına gelir parametre değildir. Parametreleri sonradan ekledik.
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,
            ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);
        }
    }
}
