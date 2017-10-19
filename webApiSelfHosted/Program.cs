using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Server.HttpSys;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting.WindowsServices;

namespace webApiSelfHosted
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).RunAsService();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
            var pathToContentRoot = Path.GetDirectoryName(pathToExe);

            return WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(pathToContentRoot)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
        }
    }
}
