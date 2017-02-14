﻿using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace MusicStore.PageObjects
{
    internal class HomePage
    {
        protected BrowserWindow browser;

        public HomePage(BrowserWindow browser)
        {
            this.browser = browser;
        }

        internal HomePage ClickStore()
        {
            HtmlHyperlink store = 
                new HtmlHyperlink(browser);
            store
                .SearchProperties
                .Add(HtmlHyperlink.PropertyNames.Href, 
                new Uri(browser.Uri, "Store").AbsoluteUri);

            Mouse.Click(store);
            return this;
        }

        internal AlbumOverviewPage SelectGenre(string genre)
        {
            HtmlHyperlink link = 
                new HtmlHyperlink(browser);
            link
                .SearchProperties
                .Add(HtmlHyperlink.PropertyNames.Href,
                new Uri(browser.Uri, "/Store/Browse?Genre=" + genre).AbsoluteUri);

            Mouse.Click(link);

            return new AlbumOverviewPage(browser);
        }
    }
}