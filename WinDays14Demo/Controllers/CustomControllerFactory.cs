using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WinDays14Demo.Models;
using WinDays14Demo.Controllers;
using System.Web.Mvc;

namespace WinDays14Demo.Controllers
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            if (controllerName.ToLower().StartsWith("home"))
            {
                ISpeakerService service = new SpeakersRepository();
                IController controller = new HomeController(service);

                return controller;
            }

            IControllerFactory factory = new DefaultControllerFactory();
            return factory.CreateController(requestContext, controllerName);
        }

        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            return System.Web.SessionState.SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            var disposalbe = controller as IDisposable;

            if (disposalbe != null)
                disposalbe.Dispose();
        }
    }
}