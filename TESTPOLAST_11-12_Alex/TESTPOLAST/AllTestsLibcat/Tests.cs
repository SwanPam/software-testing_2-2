using TESTPOLAST.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Steps;
using TESTPOLAST.Utils;
using SeleniumExtras.PageObjects;

namespace TESTPOLAST.AllTestsLibcat
{
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        private const string BookName = "Высший во всех мирах";


        [SetUp]
        public void Init()
        {
            steps.Init();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.Cleanup();
        }

        
        public void SortingCommentsOfTheSelectedAnimeByTheOldFilter()
        {
            CommonConditional commonConditional = new CommonConditional();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            AnimeLibAnimePage animeLibAnimePage = new AnimeLibAnimePage();

            steps.Login();

            commonConditional.Setup();

            PageFactory.InitElements(commonConditional.driver, animeLibAnimePage);
            animeLibAnimePage.CommentsButton.Click();
            animeLibAnimePage.DateOfRelise.Click();
            animeLibAnimePage.DateOfReliseOld.Click();

            steps.Cleanup();
        }

        //[Test]
        //public void Test2()
        //{
        //    LibcatMainPage libcatMainPage = new LibcatMainPage();
        //    LibcatBookPage libcatBookPage = new LibcatBookPage();
        //    LibcatLoginPage libcatLoginPage = new LibcatLoginPage();


        //    PageFactory.InitElements(ChromeBrowser, libcatMainPage);
        //    libcatMainPage.guestButton.Click();
        //    libcatMainPage.guestMenuLoginButton.Click();


        //    PageFactory.InitElements(ChromeBrowser, libcatLoginPage);
        //    libcatLoginPage.loginInput.SendKeys("Nk112");
        //    libcatLoginPage.passwordInput.SendKeys("123123Add");
        //    libcatLoginPage.loginButton.Click();


        //    PageFactory.InitElements(ChromeBrowser, libcatMainPage);
        //    libcatMainPage.bookLinkButton.Click();


        //    PageFactory.InitElements(ChromeBrowser, libcatBookPage);
        //    libcatBookPage.reviewsButton.Click();
        //    libcatBookPage.reviewsInput.SendKeys("Советую эту книгу");
        //    libcatBookPage.sendCommentButton.Click();
        //}


    }
}
