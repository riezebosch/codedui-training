using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using OpenQA.Selenium;

namespace MusicStore.PageObjects
{
    internal class AlbumOverviewPage : HomePage
    {
        public AlbumOverviewPage(IWebDriver driver) 
            : base(driver)
        {
        }

        internal AlbumDetailsPage SelectAlbum(string title)
        {
            driver
                .FindElement(
                    By.LinkText(title))
                .Click();
            return new AlbumDetailsPage(driver);
        }
    }
}