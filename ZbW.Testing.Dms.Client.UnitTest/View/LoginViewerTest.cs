using NUnit.Framework;
using ZbW.Testing.Dms.Client.ViewModels;
using ZbW.Testing.Dms.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.Testing.Dms.Client.UnitTest.View
{
    
    [TestFixture, RequiresSTA]
    public class LoginViewTest
    {

        [Test]
        public void TestLoginView()
        {
            LoginView loginView = new LoginView();
            Assert.IsNotNull(loginView);

            LoginViewModel loginViewModel = new LoginViewModel(loginView);
            loginViewModel.Benutzername = "TestUser";
            Assert.IsNotNull(loginViewModel);

            bool canLogin = loginViewModel.OnCanLogin();
            Assert.IsTrue(canLogin);
            loginViewModel.OnCmdLogin();
        }

    
    }
}
