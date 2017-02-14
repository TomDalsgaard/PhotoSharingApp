using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoSharingApp;
using PhotoSharingApp.Controllers;
using PhotoSharingApp.Models;
using PhotoSharingTests.Doubles;

namespace PhotoSharingApp.Tests.Controllers
{
    [TestClass]
    public class PhotoControllerTests
    {
        [TestMethod]
        public void Test_Index_Return_View()
        {
            //This test checks that the PhotoController Index action returns the Index View
            var context = new FakePhotoSharingContext();
            var controller = new PhotoController(context);
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }


    }
}
