using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoStart.Core.Interfaces;
using DemoStart.Core.Interfaces.Repository;

namespace DemoStart.Infrastructure.Services
{
   public class DemoInterfaceImplementationService:IDemoInterfaceService
    {
       private readonly IDemoInterfaceRepository _demoInterfaceRepository;

       public DemoInterfaceImplementationService(IDemoInterfaceRepository demoInterfaceRepository)
       {
           _demoInterfaceRepository = demoInterfaceRepository;
       }

       public string GetMessage()
       {
          return _demoInterfaceRepository.GetMessage();
       }
    }
}
