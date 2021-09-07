using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KawaiiAPI_Request_Example
{
    public static class Program
    {
        public static IHostBuilder CreateHostingConfig(string[] args)
        {
            //Adds all needed Services to the collection.
            var hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, collection) => collection
                    .AddHttpClient()
                    .AddSingleton<PrintApiDetails>()
                    .AddHostedService(x => x.GetRequiredService<PrintApiDetails>()));

            return hostBuilder;
        }

        public static void Main(string[] args)
        {
            try
            {
                using var host = CreateHostingConfig(args).Build();
                host.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}