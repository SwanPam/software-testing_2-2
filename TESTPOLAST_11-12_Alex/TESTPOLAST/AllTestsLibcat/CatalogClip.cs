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
    public class CatalogClip
    {
        private Steps.Steps steps = new Steps.Steps();
        [Test]
        public void CatalogClipTest()
        {

            CommonConditional commonConditional = new CommonConditional();
            commonConditional.Setup();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            AnimeLibAnimePage animeLibAnimePage = new AnimeLibAnimePage();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);

            animeLibMainPage.Catalog.Click();
            animeLibMainPage.CatalogClip.Click();

            steps.Cleanup();

        }
    }
}
