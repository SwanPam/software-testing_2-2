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
    public class SubscribeForm
    {
        private Steps.Steps steps = new Steps.Steps();
        [Test]
        public void SubscribeFormTest()
        {

            CommonConditional commonConditional = new CommonConditional();
            commonConditional.Setup();
            AnimeLibMainPage animeLibMainPage = new AnimeLibMainPage();
            FormPages formPages = new FormPages();
            PageFactory.InitElements(commonConditional.driver, animeLibMainPage);

            steps.Login();
            animeLibMainPage.Form.Click();

            PageFactory.InitElements(commonConditional.driver, formPages);
            formPages.BugAndProblems.Click();
            Thread.Sleep(3000);
            formPages.Question.Click();
            Thread.Sleep(3000);
            formPages.SubscribeForm.Click();

            steps.Cleanup();

        }
    }
}
