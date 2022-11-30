using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.pages;
using TESTPOLAST.Pages;
using TESTPOLAST.Utils;

namespace TESTPOLAST.AllTestsLibcat
{
    public class SubscribeTrans
    {
        private Steps.Steps steps = new Steps.Steps();
        [Test]
        public void SubscribeTransTest()
        {

            CommonConditional commonConditional = new CommonConditional();
            commonConditional.Setup();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            FormPages formPages = new FormPages();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);

            steps.Login();
            animeLibMainPage.SearchButton.Click();
            Thread.Sleep(3000);
            animeLibMainPage.TransSearch.Click();
            animeLibMainPage.SearchInput.SendKeys("RanobeList");
            Thread.Sleep(3000);
            animeLibMainPage.ResultSearchingClick.Click();
            Thread.Sleep(3000);
            animeLibMainPage.SubscribeTrans.Click();


            steps.Cleanup();

        }
    }
}
