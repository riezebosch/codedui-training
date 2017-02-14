using System;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITe.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace MusicStore.PageObjects
{
    internal class AlbumOverviewPage : HomePage
    {
        internal AlbumDetailsPage SelectAlbum(string title)
        {
            Browser
                .Find<HtmlHeading5>(
                    By.SearchProperties($"InnerText={title}"))
                .Parent
                .Click();
            return NavigateTo<AlbumDetailsPage>();
        }
    }
}