using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System.Net.NetworkInformation;

namespace NUnitTest.pages
{
    class AnimelibMainPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='search-link']")]
        public IWebElement searchButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[1]/input")]
        public IWebElement searchInput { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[3]/div/a")]
        public IWebElement animeSearchResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[2]/div[2]")]
        public IWebElement animeSearcByPerson { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[3]/div/a")]
        public IWebElement buttonFoundPerson { get; set; }

    }
}
