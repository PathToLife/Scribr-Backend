﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ScribrAPI.Helper;

namespace ScribrAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //YouTubeHelper.testProgram();
            //YouTubeHelper.GetTranscriptions("7_1OWdNDNLg");
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
