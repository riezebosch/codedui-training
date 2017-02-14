using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using OpenQA.Selenium;

namespace MusicStore.PageObjects
{
    internal class ShoppingCart : HomePage
    {
        public ShoppingCart(IWebDriver driver) : base(driver)
        {
        }
    }
}