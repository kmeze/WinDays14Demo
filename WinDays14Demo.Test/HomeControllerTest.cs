using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinDays14Demo.Controllers;

namespace WinDays14Demo.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void AreSpeakersInitialized()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result.ViewBag.Speakers);
        }
    }
}
