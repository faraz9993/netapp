using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

class Program
{
    public static void Main(string[] args)
    {
        // Create and run the web host for the application
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                // Use a default web API template
                webBuilder.UseStartup<Startup>();  // You'll need a Startup.cs class for ASP.NET Core
            });
}
