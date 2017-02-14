using System;
using OpenQA.Selenium;

namespace MusicStore.PageObjects
{
    internal class AlbumDetailsPage : HomePage
    {
        public AlbumDetailsPage(IWebDriver driver) 
            : base(driver)
        {
        }

        internal ShoppingCart AddToCart()
        {
            driver.FindElement(By.LinkText("Add to cart")).Click();
            return new ShoppingCart(driver);
        }
    }
}