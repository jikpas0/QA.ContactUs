using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.ContactUs;
using QA.ContactUs.Controllers;
using QA.ContactUs.Models;

namespace QA.ContactUs.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index(new Contact()) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
