using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace MusicStore.PageObjects
{
    internal class AlbumDetailsPage : HomePage
    {
        internal ShoppingCart AddToCart()
        {
            HtmlHyperlink link = new HtmlHyperlink(Browser);
            link
                .SearchProperties
                .Add(HtmlHyperlink.PropertyNames.Href, 
                    new Uri(Browser.Uri, "/ShoppingCart/AddToCart/").AbsoluteUri,
                    PropertyExpressionOperator.Contains);

            Mouse.Click(link);

            return NavigateTo<ShoppingCart>();
        }
    }
}