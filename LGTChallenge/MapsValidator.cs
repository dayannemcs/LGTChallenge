using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGTChallenge
{
    public class MapsValidator
    {
        private readonly IWebDriver browser;

        public MapsValidator (IWebDriver browser)
        {
            this.browser = browser;
        }

        protected MapsElements Map
        {
            get { return new MapsElements(this.browser); }
        }

        public void VerifyResults (string Title)
        {
            Assert.IsTrue(this.Map.Results.Text.Contains(Title), "Result does not match search");
        }
        public void VerifyDirectionsIsPresent ()
        {
            Assert.True(this.Map.DirectionsButton.Displayed);
        }
        public void VerifyDestinationValue(string City)
        {
            string value = this.Map.Destination.GetAttribute("value");
            Assert.That(value, Is.EqualTo(City));
        }

    }
}
