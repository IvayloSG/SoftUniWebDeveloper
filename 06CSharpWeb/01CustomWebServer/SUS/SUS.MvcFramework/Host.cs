﻿using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SUS.MvcFramework
{
    public static class Host
    {
        public static async Task CreateHostAsync(IMvcApplication application, int port = 80)
        {
            List<Route> routeTable = new List<Route>();
            application.configureServices();
            application.Configure(routeTable);

            IHttpServer server = new HttpServer(routeTable);
            await server.StartAsync(port);
        }
    }
}
