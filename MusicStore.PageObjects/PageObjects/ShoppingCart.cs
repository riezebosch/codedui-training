using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace MusicStore.PageObjects
{
    internal class ShoppingCart : HomePage
    {
        public ShoppingCart(BrowserWindow browser)
            : base(browser)
        {
        }
    }
}