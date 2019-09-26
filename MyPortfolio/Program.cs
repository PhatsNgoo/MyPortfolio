using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("web is starting line 17");
            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(logging=> {
                logging.ClearProviders();
                logging.AddConsole();
            })
            .UseStartup<Startup>();
    }
}
