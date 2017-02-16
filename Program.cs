using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //This
            //var applicationHost = new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build();
            //Or this?

            var applicationHost = new WebHostBuilder();
            applicationHost.UseStartup<Startup>();
            applicationHost.UseKestrel();
            //todo check the significance of this Middleware
            applicationHost.UseContentRoot(Directory.GetCurrentDirectory());
            var host = applicationHost.Build();

            host.Run();
        }
    }
}
