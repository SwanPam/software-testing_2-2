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
    public class SortingComments
    {
        private Steps.Steps steps = new Steps.Steps();
        [Test]
        public void SortingCommentsTest()
        {

            CommonConditional commonConditional = new CommonConditional();
            
            commonConditional.Setup();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            AnimeLibAnimePage animeLibAnimePage = new AnimeLibAnimePage();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);

            animeLibMainPage.SearchButton.Click();
            animeLibMainPage.SearchInput.SendKeys("Высший во всех мирах");
            Thread.Sleep(2000);
            animeLibMainPage.ResultSearchingClick.Click();

            PageFactory.InitElements(commonConditional.driver, animeLibAnimePage);
            animeLibAnimePage.CommentsButton.Click();
            animeLibAnimePage.DateOfRelise.Click();
            animeLibAnimePage.DateOfReliseOld.Click();

            steps.Cleanup();

        }

    }
}
