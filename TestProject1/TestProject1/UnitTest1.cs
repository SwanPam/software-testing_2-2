using NUnitTest.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
namespace TestProject1
{
    public class Tests
    {
        IWebDriver ChromeBrowser;

        [SetUp]
        public void Setup()
        {
            ChromeBrowser = new OpenQA.Selenium.Chrome.ChromeDriver();
            ChromeBrowser.Manage().Window.Maximize();
            ChromeBrowser.Navigate().GoToUrl("https://animelib.me/");

        }

        [Test]
        public void Test1()
        {
            AnimelibMainPage animelibMainPage = new AnimelibMainPage();
            PageFactory.InitElements(ChromeBrowser, animelibMainPage);

            animelibMainPage.searchButton.Click();
            animelibMainPage.searchInput.Click();
            animelibMainPage.searchInput.SendKeys("Высший во всех мирах");
            Thread.Sleep(4000);
            animelibMainPage.animeSearchResult.Click();
        }

        [Test]
        public void Test2()
        {
            AnimelibMainPage animelibMainPage = new AnimelibMainPage();
            PersonPage personPage = new PersonPage();

            PageFactory.InitElements(ChromeBrowser, animelibMainPage);
            animelibMainPage.searchButton.Click();
            animelibMainPage.animeSearcByPerson.Click();
            animelibMainPage.searchInput.SendKeys("Jksmanga");
            Thread.Sleep(2000); 
            animelibMainPage.buttonFoundPerson.Click();

        }
    }
}