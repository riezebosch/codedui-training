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
            var img = new HtmlImage(browser);
            img.SearchProperties[HtmlImage.PropertyNames.Alt] = title;
            img.EnsureClickable();

            Mouse.Click(img);

            return new AlbumDetailsPage(browser);
        }
    }
}