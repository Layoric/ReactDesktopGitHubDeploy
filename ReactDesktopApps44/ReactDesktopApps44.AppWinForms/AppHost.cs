﻿using System;
using System.Threading.Tasks;
using System.IO;
using Funq;
using ServiceStack;
using Squirrel;
using ReactDesktopApps44.Resources;
using ReactDesktopApps44.ServiceInterface;

namespace ReactDesktopApps44.AppWinForms
{
    public class AppHost : AppSelfHostBase
    {
        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("ReactDesktopApps44.AppWinForms", typeof(MyServices).Assembly)
        { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        /// <param name="container"></param>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //Plugins.Add(new CorsFeature());

            SetConfig(new HostConfig
            {
                DebugMode = true,
                EmbeddedResourceBaseTypes = { typeof(AppHost), typeof(SharedEmbeddedResources) },
            });
        }
    }
}
