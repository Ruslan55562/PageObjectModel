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
            LoginPage.GetEnterYourEmailText();
            LoginPage.GetAlreadyRegisteredText();
            LoginPage.GetCreateAnAccountText();
          
        }
      
        [Test]
         public void SignIn()
        {
            var loginPage = new LoginPage();
            PageFactory.InitElements(_webDriver, loginPage);
            loginPage.SignInToSite("user1@ukr.net", "qwerty");
        }


        [OneTimeTearDown]
        protected void TearDown()
        {
            if (_webDriver != null)
                _webDriver.Quit();
        }
    }

}