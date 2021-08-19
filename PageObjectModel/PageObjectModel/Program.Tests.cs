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
        LoginPage _loginPage; 


        [OneTimeSetUp]
        protected void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(@"http://automationpractice.com/index.php?controller=authentication&back=my-account");
            _loginPage = new LoginPage(_webDriver);
            
        }
       
        [Test]
        public void GetTextValues()
        {
            _loginPage.GetEnterYourEmailText();
            _loginPage.GetAlreadyRegisteredText();
            _loginPage.GetCreateAnAccountText();
        }
      
        [Test]
         public void SignIn()
        {
            _loginPage.SignInToSite("user1@ukr.net", "qwerty");
        }


        [OneTimeTearDown]
        protected void TearDown()
        {
            if (_webDriver != null)
                _webDriver.Quit();
        }
    }

}