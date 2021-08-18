using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.PageObjects;
using SeleniumExtras.PageObjects;

namespace PageObjectModel
{
    public class Tests
    {
        
        protected IWebDriver _webDriver;
        [OneTimeSetUp]
        protected void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(@"http://automationpractice.com/index.php?controller=authentication&back=my-account");
            
        }
       
        [Test]
        public void GetTextValues()
        {
            var LoginPage = new LoginPage();
            PageFactory.InitElements(_webDriver, LoginPage);
            LoginPage.GetEnterYourEmail_Text();
            LoginPage.GetAlreadyRegistered_Text();
            LoginPage.GetCreateAnAccount_Text();
          
        }
      
       
        [Test]
         public void SignIn()
        {
            var loginPage = new LoginPage();
            PageFactory.InitElements(_webDriver, loginPage);
            loginPage.SignInTo_Site("user1", "qwerty");
        }


        [OneTimeTearDown]
        protected void TearDown()
        {
            if (_webDriver != null)
                _webDriver.Quit();
        }
    }
}