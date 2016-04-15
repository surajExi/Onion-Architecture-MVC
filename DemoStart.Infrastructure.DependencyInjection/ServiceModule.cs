using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoStart.Core.Interfaces;
using DemoStart.Infrastructure.Logging;
using DemoStart.Infrastructure.Services;
using Ninject.Modules;

namespace DemoStart.Infrastructure.DependencyInjection
{
   public class ServiceModule : NinjectModule
    {
       public override void Load()
       {
           //TO DO BINDINGS..
           Bind<IDemoInterfaceService>().To<DemoInterfaceImplementationService>();
          
       }
    }
}
