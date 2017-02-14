using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace MusicStore.PageObjects
{
    internal class AlbumDetailsPage
    {
        private BrowserWindow browser;

        public AlbumDetailsPage(BrowserWindow browser)
        {
            this.browser = browser;
        }

        internal void AddToCart()
        {
            HtmlHyperlink link = new HtmlHyperlink(browser);
            link
                .SearchProperties
                .Add(HtmlHyperlink.PropertyNames.Href, 
                    new Uri(browser.Uri, "/ShoppingCart/AddToCart/").AbsoluteUri,
                    PropertyExpressionOperator.Contains);

            Mouse.Click(link);
        }
    }
}