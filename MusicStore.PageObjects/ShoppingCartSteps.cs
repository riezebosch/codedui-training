using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace MusicStore.PageObjects
{
    [Binding]
    public class ShoppingCartSteps
    {
        [Given(@"I have an empty shopping cart")]
        public void GivenIHaveAnEmptyShoppingCart()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";
            ScenarioContext.Current.Set(driver);

            var home = new HomePage(driver);
            ScenarioContext.Current.Set(home);
        }
        
        [When(@"I select '(.*)' from the Store submenu")]
        public void WhenISelectFromTheStoreSubmenu(string genre)
        {
            var home = ScenarioContext.Current.Get<HomePage>();
            var albums = home.ClickStore().SelectGenre(genre);

            ScenarioContext.Current.Set(albums);
        }
        
        [When(@"I select '(.*)' from the overview")]
        public void WhenISelectFromTheOverview(string title)
        {
            var albums = ScenarioContext.Current.Get<AlbumOverviewPage>();
            var details = albums.SelectAlbum(title);

            ScenarioContext.Current.Set(details);
        }
        
        [When(@"I add this item to the cart")]
        public void WhenIAddThisItemToTheCart()
        {
            var details = ScenarioContext.Current.Get<AlbumDetailsPage>();
            var cart = details.AddToCart();

            ScenarioContext.Current.Set(cart);
        }
        
        [Then(@"the number on the shopping cart should be (.*)")]
        public void ThenTheNumberOnTheShoppingCartShouldBe(int total)
        {
            var cart = ScenarioContext.Current.Get<ShoppingCart>();
            Assert.Equal(total, cart.CartStatus());
        }

        [When(@"I add '(.*)' from the '(.*)' albums")]
        public void WhenIAddFromTheAlbums(string title, string genre)
        {
            var home = ScenarioContext.Current.Get<HomePage>();
            var cart = home
                .ClickStore()
                .SelectGenre(genre)
                .SelectAlbum(title)
                .AddToCart();

            ScenarioContext.Current.Set(cart);
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            driver?.Close();
        }
    }
}
