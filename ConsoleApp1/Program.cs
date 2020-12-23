using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddScoped<IDbContextMock, DbContextMock>();
            services.AddTransient<ISomeService, SomeService>();
            var globalProvider = services.BuildServiceProvider();

            using (var scope = globalProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<IDbContextMock>();
                var dbContextFromService = scope.ServiceProvider.GetService<ISomeService>().DbContext;

                Assert.Equal(dbContext, dbContextFromService);
                Console.WriteLine("Equal");
            }

            Console.ReadLine();
        }
    }
}
