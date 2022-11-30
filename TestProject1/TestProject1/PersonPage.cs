using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace NUnitTest.pages
{
    class PersonPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='main - page']/div/div/div[1]/div/div/div[2]/button/span")]
        public IWebElement subscribeToAPerson { get; set; }
    }
}
