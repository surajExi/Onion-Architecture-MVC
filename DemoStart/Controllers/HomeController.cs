using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoStart.Core.Interfaces;
using DemoStart.Infrastructure.Services;

namespace DemoStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDemoInterfaceService _demoInterface;
        private readonly ILoggingService _loggingService;

        public HomeController(IDemoInterfaceService demoInterface,ILoggingService loggingService)
        {
            _demoInterface = demoInterface;
            _loggingService = loggingService;
        }


        public ActionResult Index()
        {
            try
            {
               string message = _demoInterface.GetMessage();
                ViewBag.Message = message;
                throw new Exception("A test exception");
            }
            catch (Exception ex)
            {
                
                _loggingService.Error(ex);
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}