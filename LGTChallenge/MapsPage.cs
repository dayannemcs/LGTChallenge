using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGTChallenge
{
    public class MapsPage
    {
        private readonly IWebDriver browser;
        private readonly string url = @"https://www.google.com/maps";

        public MapsPage (IWebDriver browser)
        {
            this.browser = browser;
        }

        protected MapsElements Map
        {
            get { return new MapsElements(this.browser); }
        }

        public MapsValidator Validate()
        {
            return new MapsValidator(this.browser);
        }

        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(this.url);
        }

        public void Consent()
        {
            this.Map.Accept.Click();
        }

        public void Search (string City)
        {
            this.Map.SearchBox.Click();
            this.Map.SearchBoxInput.SendKeys(City);
            this.Map.SearchButton.Click();
            
        }
        public void Directions (string City)
        {
            this.Map.SearchBox.Click();
            this.Map.SearchBoxInput.SendKeys(City);
            this.Map.SearchButton.Click();
            this.Map.DirectionsButton.Click();
        }
        public void Destination (string City)
        {
            this.Map.SearchBox.Click();
            this.Map.SearchBoxInput.SendKeys(City);
            this.Map.SearchButton.Click();
            this.Map.DirectionsButton.Click();
            this.Map.Destination.Click();
        }
    }
}
