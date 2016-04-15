using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoStart.Core.Interfaces.Repository;

namespace DemoStart.Infrastructure.Repository
{
   public class DemoInterfaceImplementationRepository:IDemoInterfaceRepository
    {
       public string GetMessage()
       {
           return this.ToString();
       }
    }
}
