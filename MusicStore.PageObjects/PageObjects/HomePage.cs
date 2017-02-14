using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

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

            store.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            Mouse.Click(store);
            return this;
        }

        internal AlbumOverviewPage SelectGenre(string genre)
        {
            HtmlHyperlink link = 
                new HtmlHyperlink(browser);
            link
                .SearchProperties
                .Add(HtmlHyperlink.PropertyNames.InnerText, genre);

            Mouse.Click(link);

            return new AlbumOverviewPage(browser);
        }

        internal int? CartStatus()
        {
            var span = new HtmlSpan(browser);
            span.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "cart-status");

            return span.Exists ? (int?)int.Parse(span.InnerText) : null;
        }
    }
}