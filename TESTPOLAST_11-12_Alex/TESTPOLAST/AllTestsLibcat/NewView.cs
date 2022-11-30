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
    public class NewView
    {

        private Steps.Steps steps = new Steps.Steps();
        [Test]
        public void NewViewTest()
        {

            CommonConditional commonConditional = new CommonConditional();
            commonConditional.Setup();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            ProfilePages profilePages = new ProfilePages();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);

            steps.Login();
            animeLibMainPage.IconProfile.Click();
            animeLibMainPage.MyProfile.Click();

            PageFactory.InitElements(commonConditional.driver, profilePages);
            profilePages.Edit.Click();
            Thread.Sleep(2000);
            profilePages.InputView.SendKeys("Любимые тайтлы");
            profilePages.PlusView.Click();

            steps.Cleanup();

        }
    }
}
