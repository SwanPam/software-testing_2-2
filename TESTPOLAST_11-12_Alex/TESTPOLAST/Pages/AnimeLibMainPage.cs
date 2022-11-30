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
    internal class AnimeLibMainPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[2]/div/div[3]/a[1]")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search-link']")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[1]/input")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[3]")]
        public IWebElement ResultSearchingClick { get; set; }





        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[2]/div/div[2]/div/div[1]/span")]
        public IWebElement Catalog { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='tippy-2']/div/div/div/a[8]")]
        public IWebElement CatalogAll { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id=\"site_type\"]/body/div[2]/div/div[3]/div[3]/img")]
        public IWebElement IconProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tippy-6\"]/div/div/div/a[1]")]
        public IWebElement MyProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"site_type\"]/body/div[2]/div/div[2]/div/div[3]/a")]
        public IWebElement Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[2]/div[1]/div[1]/div/div[1]")]
        public IWebElement Janr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[2]/div[3]/div[3]/div[2]/div/div[50]/span[2]")]
        public IWebElement JanrFantasy { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[2]/div[3]/div[4]/button")]
        public IWebElement JanrAccept { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[1]/div[1]/div/div/button/span")]
        public IWebElement Score { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tippy-5\"]/div/div/div/label[4]/span[2]")]
        public IWebElement DateAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"site_type\"]/body/div[1]/div/div/div[2]/div[2]")]
        public IWebElement PersonSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[1]/div/div/div[2]/button/span")]
        public IWebElement SubscribeAut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"site_type\"]/body/div[1]/div/div/div[2]/div[4]")]
        public IWebElement TransSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"site_type\"]/body/div[1]/div/div/div[2]/div[5]")]
        public IWebElement UsersSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[1]/div[2]/button/span")]
        public IWebElement SubscribeTrans { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tippy-2\"]/div/div/div/a[7]")]
        public IWebElement CatalogClip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"follow-toggle\"]")]
        public IWebElement FriendUser { get; set; }

        
    }
}
