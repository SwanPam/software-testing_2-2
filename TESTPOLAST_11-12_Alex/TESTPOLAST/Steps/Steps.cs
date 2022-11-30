using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Driver;
using TESTPOLAST.pages;
using TESTPOLAST.Utils;

namespace TESTPOLAST.Steps
{
    public class Steps
    {
        CommonConditional commonConditional = new CommonConditional();

        [SetUp]
        public void Init()
        {
            commonConditional.Setup();
        }

        [TearDown]
        public void Cleanup()
        {
            commonConditional.logging.logstr = "Test AddBookBiblioTest Success";
            commonConditional.logging.LogText();
            DriverSingleton.CloseDriver();
        }

        public void Login()
        {
            CommonConditional commonConditional = new CommonConditional();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            AnimeLibLoginPages animeLibLoginPages = new AnimeLibLoginPages();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);
            animeLibMainPage.LoginButton.Click();
            PageFactory.InitElements(commonConditional.driver, animeLibLoginPages);
            animeLibLoginPages.LoginInput.SendKeys("shulyak.1975@bk.ru");
            animeLibLoginPages.PasswordInput.SendKeys("123452");
            animeLibLoginPages.ButtonEnter.Click();
        }
    }
}
