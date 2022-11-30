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
    public class SortingJanr
    {
        private Steps.Steps steps = new Steps.Steps();
        [Test]
        public void SortingJanrTest()
        {

            CommonConditional commonConditional = new CommonConditional();

            commonConditional.Setup();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);

            animeLibMainPage.Catalog.Click();
            animeLibMainPage.CatalogAll.Click();
            Thread.Sleep(3000);
            animeLibMainPage.Janr.Click();
            animeLibMainPage.JanrFantasy.Click();
            animeLibMainPage.JanrAccept.Click();
            animeLibMainPage.Score.Click();
            Thread.Sleep(3000);
            animeLibMainPage.DateAdd.Click();

            steps.Cleanup();

        }
    }
}
