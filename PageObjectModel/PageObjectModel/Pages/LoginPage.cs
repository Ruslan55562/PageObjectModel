using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace PageObjectModel.PageObjects
{
    public class LoginPage
    {


        #region LOCATORS
        //CREATE-ACCOUNT FORM

        // Summary: 'Authentication title'.
        [FindsBy(How = How.XPath, Using = "//h1[@class='page-heading']")]
        private IWebElement AuthenticationTitle { set; get; }

        // Summary: 'Create an account' title.
        [FindsBy(How = How.XPath, Using = "//form[@id='create-account_form']/h3")]
        private IWebElement CreateAnAccountTitle { set; get; }

        // Summary: 'Please enter your emeil address to create an account' text.
        [FindsBy(How = How.XPath, Using = "//form[@id='create-account_form']/div/p")]
        private IWebElement PleaseEnterYourEmailText { set; get; }

        // Summary: 'Email address ' field(create a new user).
        [FindsBy(How = How.XPath, Using = "//input[@id='email_create']")]
        private IWebElement EmailAdressFieldCreate { set; get; }

        // Summary: 'Create an account - button'.
        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitCreate']")]
        private IWebElement CreateAnAccountButton { set; get; }

        
        //LOGIN FORM

        // Summary: 'AlreadyRegistered' - title.
        [FindsBy(How = How.XPath, Using = "//form[@id='login_form']/h3")]
        private IWebElement AlreadyRegisteredTitle { set; get; }

        // Summary: 'Email adress' - field(User is already registered).
        [FindsBy(How = How.XPath, Using = " //input[@id='email']")]
        private IWebElement EmailAdressFieldLogin { set; get; }

        // Summary: 'password' - field(User is already registered).
        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        private IWebElement PasswordField { set; get; }

        // Summary: 'Forgot your password' - link.
        [FindsBy(How = How.XPath, Using = "//p[@class='lost_password form-group']/a")]
        private IWebElement ForgotYourPasswordLink { set; get; }

        // Summary: 'Sign in' - button.
        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']")]
        private IWebElement SignInButton { set; get; }
        #endregion




        #region FUNCTIONS
        //Get_Text Functions
        public void GetEnterYourEmailText()
        {
            Console.WriteLine(PleaseEnterYourEmailText.Text);
        }

        public void GetAlreadyRegisteredText()
        {
            Console.WriteLine(AlreadyRegisteredTitle.Text);
        }

        public void GetCreateAnAccountText()
        {
            Console.WriteLine(CreateAnAccountButton.Text);
        }

        //The method takes 2 arguments(login,passwd) and put them into corresponding fields. Then clicks the "SignIn" button.
        public void SignInToSite(string login, string passwd)
        {
            EmailAdressFieldLogin.SendKeys(login);
            PasswordField.SendKeys(passwd);
            SignInButton.Click();
        }
        #endregion
    }
}
