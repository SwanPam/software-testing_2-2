using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TESTPOLAST.pages
{
    internal class AnimeLibAnimePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div/div[2]/div[2]/div[1]/div/ul/li[3]")]
        public IWebElement CommentsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div/div[2]/div[2]/div[4]/div/section/div[1]/div/button")]
        public IWebElement DateOfRelise { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tippy-9\"]/div/div/div/div/div[2]")]
        public IWebElement DateOfReliseOld { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"button-change-status\"]/div")]
        public IWebElement ListAnime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tippy-6\"]/div/div/div/div[1]/div[4]")]
        public IWebElement AnimeSee { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tippy-6\"]/div/div/div/div[1]/div[7]")]
        public IWebElement AnimeDelete { get; set; }
    }
}
