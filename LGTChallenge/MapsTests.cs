using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace LGTChallenge
{
    public class Tests
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }


        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            this.Driver = new ChromeDriver(options);
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TearDown]
        protected void TearDown()
        {
            this.Driver.Quit();
        }

        [Test]
        public void SearchCity()
        {
            MapsPage search = new MapsPage(this.Driver);
            search.Navigate();
            search.Consent();
            search.Search("Dublin");
            search.Validate().VerifyResults("Dublin");

        }
        [Test]
        public void VerifyDirectionsEnabled()
        {
            MapsPage search = new MapsPage(this.Driver);
            search.Navigate();
            search.Consent();
            search.Directions("Dublin");
            search.Validate().VerifyDirectionsIsPresent();
        }
        [Test]
        public void VerifyDestination()
        {
            MapsPage search = new MapsPage(this.Driver);
            search.Navigate();
            search.Consent();
            search.Directions("Dublin");
            search.Validate().VerifyDestinationValue("Dublin, Irlanda");
        }

    }
}