using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Linq;

namespace MusicStore.PageObjects
{
    internal class AlbumOverviewPage
    {
        private BrowserWindow browser;

        public AlbumOverviewPage(BrowserWindow browser)
        {
            this.browser = browser;
        }

        internal AlbumDetailsPage SelectAlbum(string title)
        {
            var label = new HtmlControl(browser);
            label.SearchProperties[HtmlControl.PropertyNames.TagName] = "h5";
            label.SearchProperties[HtmlControl.PropertyNames.InnerText] = title;

            var link = label.GetParent();
            Mouse.Click(link);

            return new AlbumDetailsPage(browser);
        }
    }
}