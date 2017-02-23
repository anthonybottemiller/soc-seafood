using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOCSeafood.Controllers;
using SOCSeafood.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace SOCSeafood.Tests.ControllerTests
{
    public class SubscribersControllerTest
    {

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            SubscribersController controller = new SubscribersController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Create_Test()
        {
            SubscribersController controller = new SubscribersController();

            var result = controller.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            SubscribersController controller = new SubscribersController();

            IActionResult actionResult = controller.Index();

            ViewResult indexView = controller.Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsType<List<Subscriber>>(result);
        }

    }
}
