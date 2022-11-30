using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTPOLAST.Pages
{
    public class FormPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[1]/div[2]/div[2]/div[2]/div[3]")]
        public IWebElement BugAndProblems { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[2]/div[3]/div[1]/div/div[1]/h2/a")]
        public IWebElement Question { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[2]/div/div[1]/button/span")]
        public IWebElement SubscribeForm { get; set; }
    }
}
