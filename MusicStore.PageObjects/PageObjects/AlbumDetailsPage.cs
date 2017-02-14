using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace MusicStore.PageObjects
{
    internal class AlbumDetailsPage : HomePage
    {
        public AlbumDetailsPage(BrowserWindow browser)
            : base(browser)
        {
        }

        internal ShoppingCart AddToCart()
        {
            HtmlHyperlink link = new HtmlHyperlink(browser);
            link
                .SearchProperties
                .Add(HtmlHyperlink.PropertyNames.Href, 
                    new Uri(browser.Uri, "/ShoppingCart/AddToCart/").AbsoluteUri,
                    PropertyExpressionOperator.Contains);

            Mouse.Click(link);

            return new ShoppingCart(browser);
        }
    }
}