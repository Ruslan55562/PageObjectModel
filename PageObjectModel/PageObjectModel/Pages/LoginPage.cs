using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;



namespace PageObjectModel.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #region LOCATORS
        //CREATE-ACCOUNT FORM

        // Summary: 'Authentication title'.
        [FindsBy(How = How.XPath, Using = "//h1[@class='page-heading']")]
        [CacheLookup]
        private IWebElement AuthenticationTitle { set; get; }

        // Summary: 'Create an account' title.
        [FindsBy(How = How.XPath, Using = "//form[@id='create-account_form']/h3")]
        [CacheLookup]
        private IWebElement CreateAnAccountTitle { set; get; }

        // Summary: 'Please enter your emeil address to create an account' text.
        [FindsBy(How = How.XPath, Using = "//form[@id='create-account_form']/div/p")]
        [CacheLookup]
        private IWebElement PleaseEnterYourEmailText { set; get; }

        // Summary: 'Email address ' field(create a new user).
        [FindsBy(How = How.XPath, Using = "//input[@id='email_create']")]
        [CacheLookup]
        private IWebElement EmailAdressFieldCreate { set; get; }

        // Summary: 'Create an account - button'.
        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitCreate']")]
        [CacheLookup]
        private IWebElement CreateAnAccountButton { set; get; }

        
        //LOGIN FORM

        // Summary: 'AlreadyRegistered' - title.
        [FindsBy(How = How.XPath, Using = "//form[@id='login_form']/h3")][CacheLookup]
        private IWebElement AlreadyRegisteredTitle { set; get; }

        // Summary: 'Email adress' - field(User is already registered).
        [FindsBy(How = How.XPath, Using = " //input[@id='email']")][CacheLookup]
        private IWebElement EmailAdressFieldLogin { set; get; }

        // Summary: 'password' - field(User is already registered).
        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")][CacheLookup]
        private IWebElement PasswordField { set; get; }

        // Summary: 'Forgot your password' - link.
        [FindsBy(How = How.XPath, Using = "//p[@class='lost_password form-group']/a")][CacheLookup]
        private IWebElement ForgotYourPasswordLink { set; get; }

        // Summary: 'Sign in' - button.
        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']")] [CacheLookup]
        private IWebElement SignInButton { set; get; }
        #endregion




        #region FUNCTIONS
        //Get_Text Functions
        public LoginPage GetEnterYourEmailText()
        {
            Console.WriteLine(PleaseEnterYourEmailText.Text);
            return this;
        }

        public LoginPage GetAlreadyRegisteredText()
        {
            Console.WriteLine(AlreadyRegisteredTitle.Text);
            return this;
            
        }

        public LoginPage GetCreateAnAccountText()
        {
            Console.WriteLine(CreateAnAccountButton.Text);
            return this;
        }

        //The method takes 2 arguments(login,passwd) and put them into corresponding fields. Then clicks the "SignIn" button.
        public LoginPage SignInToSite(string login, string passwd)
        {
            EmailAdressFieldLogin.SendKeys(login);
            PasswordField.SendKeys(passwd);
            SignInButton.Click();
            return this;
        }
        #endregion
    }
}
