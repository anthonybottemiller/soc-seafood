using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOCSeafood.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace SOCSeafood.Tests.ControllerTests
{
    public class AccountControllerTest
    {
        [Fact]
        public void Get_ViewResult_Login_Test()
        {
            AccountController controller = new AccountController();

            var result = controller.Login();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Logout_Test()
        {
            AccountController controller = new AccountController();

            var result = controller.Logout();

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Get_ViewResult_Register_Test()
        {
            AccountController controller = new AccountController();

            var result = controller.Register();

            Assert.IsType<ViewResult>(result);
        }

    }
}
