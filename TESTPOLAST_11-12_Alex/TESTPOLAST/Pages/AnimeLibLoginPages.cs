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
    internal class AnimeLibLoginPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[2]/div[1]/form/div[2]/div/input")]
        public IWebElement LoginInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[2]/div[1]/form/div[3]/div/input")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[2]/div[1]/form/div[5]/button")]
        public IWebElement ButtonEnter { get; set; }
    }
}
