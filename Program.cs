using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace webapp
{
    public class Program
    {
		public static void Main(string[] args)
		{
			var url = $"http://*:{Environment.GetEnvironmentVariable("PORT")}/";
			Console.WriteLine($"Using Url: {url}");
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseIISIntegration()
				.UseStartup<Startup>()
				.UseUrls(url)
				.Build();
			host.Run();
		} 

    }
}





/*
  public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
 */
