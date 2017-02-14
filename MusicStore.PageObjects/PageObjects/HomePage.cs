using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace MusicStore.PageObjects
{
    internal class HomePage
    {
        protected IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal HomePage ClickStore()
        {
            driver
                .FindElement(By.CssSelector("a[href='/Store']"))
                .Click();
            return this;
        }

        internal AlbumOverviewPage SelectGenre(string genre)
        {
            driver
                .FindElement(
                    By.LinkText(genre))
                .Click();

            return new AlbumOverviewPage(driver);
        }

        internal int? CartStatus()
        {
            var span = driver.FindElement(By.Id("cart-status"));
            return span.Displayed ? (int?)int.Parse(span.Text) : null;
        }
    }
}