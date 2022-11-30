using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.pages;
using TESTPOLAST.Utils;

namespace TESTPOLAST.AllTestsLibcat
{
    public class SercgUser
    {
        private Steps.Steps steps = new Steps.Steps();
        [Test]
        public void SubscribeAuthorTest()
        {

            CommonConditional commonConditional = new CommonConditional();
            commonConditional.Setup();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            AnimeLibAnimePage animeLibAnimePage = new AnimeLibAnimePage();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);

            steps.Login();
            animeLibMainPage.SearchButton.Click();
            Thread.Sleep(3000);
            animeLibMainPage.UsersSearch.Click();
            animeLibMainPage.SearchInput.SendKeys("daniel2");
            Thread.Sleep(3000);
            animeLibMainPage.ResultSearchingClick.Click();
            Thread.Sleep(3000);
            animeLibMainPage.FriendUser.Click();

            steps.Cleanup();

        }
    }
}
