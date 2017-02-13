using System;
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
            var host = applicationHost.Build();

            host.Run();
        }
    }
}
