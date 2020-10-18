using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.MvcFramework
{
    public interface IMvcApplication
    {
        void configureServices();

        void Configure(List<Route> routeTable);
    }
}
