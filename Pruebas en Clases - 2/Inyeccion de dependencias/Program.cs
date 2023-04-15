using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Inyección de dependecias

namespace Inyeccion_de_dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) => services
                    .AddTransient<ITransientOperation, DefaultOperation>()
                    .AddScoped<IScopedOperation, DefaultOperation>()
                    .AddSingleton<ISingletonOperation, DefaultOperation>()
                    .AddTransient<LoggerOperation>())
            .Build();

            EjemploScope(host.Services, "Scope 1");
            EjemploScope(host.Services, "Scope 2");
            host.StartAsync(); // Iniciamos asincrono
        }
        static void EjemploScope(IServiceProvider services, string scope) {
            IServiceScope serviceScope = services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;

            LoggerOperation logger = provider.GetRequiredService<LoggerOperation>();
            logger.LogOperation($"{scope}: --Ejecutando... GetRequiredService<LoggerOperation>()");
            Console.WriteLine();

            /*
            logger = provider.GetRequiredService<LoggerOperation>();
            logger.LogOperation($"{scope}: --Ejecutando... GetRequiredService<LoggerOperation>()");
            Console.WriteLine();
            */
        }
    }
}

