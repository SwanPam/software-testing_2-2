using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTPOLAST.Pages
{
    public class ProfilePages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-page\"]/div/div/div[2]/div[1]/div/div[1]/div[2]")]
        public IWebElement Edit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"site_type\"]/body/div[7]/div/div/div/div/div[4]/input")]
        public IWebElement InputView { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"site_type\"]/body/div[7]/div/div/div/div/div[4]/div")]
        public IWebElement PlusView { get; set; }
    }
}
