using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;
using CUITe.Controls.HtmlControls;

namespace MusicStore.PageObjects
{
    internal class HomePage : Page
    {
        internal HomePage ClickStore()
        {
            Browser
                .Find<HtmlHyperlink>(
                    By.SearchProperties($"href={new Uri(Browser.Uri, "/Store").AbsoluteUri}"))
                .Click();
            return this;
        }

        internal AlbumOverviewPage SelectGenre(string genre)
        {
            Browser
                .Find<HtmlHyperlink>(
                    By.SearchProperties($"InnerText={genre}"))
                .Click();
            return NavigateTo<AlbumOverviewPage>();
        }

        internal int? CartStatus()
        {
            var span = Browser.Find<HtmlSpan>(By.Id("cart-status"));
            return span.Exists ? (int?)int.Parse(span.InnerText) : null;
        }
    }
}