﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demochat.Startup))]
namespace Demochat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
