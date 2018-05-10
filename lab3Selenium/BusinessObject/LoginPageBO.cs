using lab3SeleniumInfrastracture.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3SeleniumInfrastracture.BusinessObject
{
    public class LoginPageBO
    {
        private LoginPage LoginPage;

        LoginPageBO()
        {
            LoginPage = new LoginPage();
        }

        public void EnterEmail()
        {
            LoginPage.LoginField.SendKeys("veronikashportko@gmail.com");
        }

        public void ClickNextButton()
        {
            LoginPage.NextButton.Click();
        }
    }
}
