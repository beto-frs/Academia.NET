using EntityFramework.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using static System.Console;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();

            serviceCollection
                .AddSingleton<Email>()
                .AddSingleton<Contexto>()
                .AddSingleton<Initial>()
                .AddSingleton<Pessoa>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var testInstance = serviceProvider.GetService<Initial>();
            testInstance.Start();

        }
       
    }
}
