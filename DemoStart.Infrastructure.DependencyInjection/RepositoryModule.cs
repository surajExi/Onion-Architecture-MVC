using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoStart.Core.Interfaces.Repository;
using DemoStart.Infrastructure.Repository;
using Ninject.Modules;

namespace DemoStart.Infrastructure.DependencyInjection
{
    public class RepositoryModule :NinjectModule
    {
        public override void Load()
        {
            // TO DO BINDINGS..
            Bind<IDemoInterfaceRepository>().To<DemoInterfaceImplementationRepository>();
        }
    }
}
