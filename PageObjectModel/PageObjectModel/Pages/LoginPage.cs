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

        // <summary>'Authentication title'</summary>
        [FindsBy(How = How.XPath, Using = "//h1[@class='page-heading']")]
        public IWebElement AuthenticationTitle { set; get; }

        // <summary>'Create an account' title </summary>
        [FindsBy(How = How.XPath, Using = "//form[@id='create-account_form']/h3")]
        public IWebElement CreateAnAccountTitle { set; get; }

        // <summary>'Please enter your emeil address to create an account' text </summary>
        [FindsBy(How = How.XPath, Using = "//form[@id='create-account_form']/div/p")]
        public IWebElement PleaseEnterYourEmailText { set; get; }

        // <summary>'Email address ' field(create a new user) </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='email_create']")]
        public IWebElement EmailAdressFieldCreate { set; get; }

        // <summary>'Create an account - button'</summary>
        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitCreate']")]
        public IWebElement CreateAnAccountButton { set; get; }

        
        //LOGIN FORM

        // <summary>'AlreadyRegistered' - title</summary>
        [FindsBy(How = How.XPath, Using = "//form[@id='login_form']/h3")]
        public IWebElement AlreadyRegisteredTitle { set; get; }

        // <summary>'Email adress' - field(User is already registered)</summary>
        [FindsBy(How = How.XPath, Using = " //input[@id='email']")]
        public IWebElement EmailAdressFieldLogin { set; get; }

        // <summary>'password' - field(User is already registered)</summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        public IWebElement PasswordField { set; get; }

        // <summary>'Forgot your password' - link </summary>
        [FindsBy(How = How.XPath, Using = "//p[@class='lost_password form-group']/a")]
        public IWebElement ForgotYourPasswordLink { set; get; }

        // <summary>'Sign in' - button </summary>
        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']")]
        public IWebElement SignInButton { set; get; }
        #endregion




        #region FUNCTIONS
        //Get_Text Functions
        public void GetEnterYourEmail_Text()
        {
            Console.WriteLine(PleaseEnterYourEmailText.Text);
           
        }

        public void GetAlreadyRegistered_Text()
        {
            Console.WriteLine(AlreadyRegisteredTitle.Text);
        }

        public void GetCreateAnAccount_Text()
        {
            Console.WriteLine(CreateAnAccountButton.Text);
        }


        //The method takes 2 arguments(login,passwd) and put them into corresponding fields. Then clicks the "SignIn" button.
        public void SignInTo_Site(string login, string passwd)
        {

            /* WebDriverWait - for practice (third param - IWebDriver wb)
           // WebDriverWait wait = new WebDriverWait(wb, TimeSpan.FromSeconds(5));
           // wait.Until(ExpectedConditions.ElementToBeClickable(EmailAdressFieldLogin));*/


            EmailAdressFieldLogin.SendKeys(login);
            // wait.Until(ExpectedConditions.ElementToBeClickable(PasswordField));
            PasswordField.SendKeys(passwd);
            // wait.Until(ExpectedConditions.ElementToBeClickable(SignInButton));
            SignInButton.Click();

        }
        #endregion
    }
}
