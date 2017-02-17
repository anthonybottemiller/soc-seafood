using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOCSeafood.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace SOCSeafood.Tests.ControllerTests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            HomeController controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
