using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGTChallenge
{
    public class MapsElements
    {
        private readonly IWebDriver browser;

        public MapsElements (IWebDriver browser)
        {
            this.browser = browser;
        }
        public IWebElement SearchBox
        {
            get { return this.browser.FindElement(By.Id("searchbox-searchbutton")); }
        }

        public IWebElement SearchBoxInput
        {
            get { return this.browser.FindElement(By.Id("searchboxinput")); }
        }
        public IWebElement SearchButton
        {
            get { return this.browser.FindElement(By.Id("searchbox-searchbutton")); }
        }
        public IWebElement Results
        {
            get { return this.browser.FindElement(By.CssSelector(".x3AX1-LfntMc-header-title-title > span:nth-child(1)")); }
        }

        public IWebElement Accept
        { 
            get { return this.browser.FindElement(By.XPath("/html/body/c-wiz/div/div/div/div[2]/div[1]/div[4]/form/div[1]/div/button/span")); }
        }

        public IWebElement DirectionsButton 
        {
            get { return this.browser.FindElement((By.CssSelector(".pChizd .EgL07d"))); }
        }
        public IWebElement Destination
        {
            get { return this.browser.FindElement((By.CssSelector("#sb_ifc52 > .tactile-searchbox-input"))); }
        }





    }
}
