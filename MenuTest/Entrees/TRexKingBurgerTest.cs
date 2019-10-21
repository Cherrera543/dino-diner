using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void NotifyofPropertyChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldBun();
                t.HoldLettuce();
                t.HoldKetchup();
                t.HoldMayo();
                t.HoldMustard();
                t.HoldOnion();
                t.HoldPickle();
                t.HoldTomato();
            });
        }
        [Fact]
        public void ShouldHaveCorrectSpecials()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
            t.bun = true;
            t.HoldKetchup();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
            t.ketchup = true;
            t.HoldLettuce();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
            t.lettuce = true;
            t.HoldMayo();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Mayo", item);
            });
            t.mayo = true;
            t.HoldMustard();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
            t.mustard = true;
            t.HoldOnion();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
            t.onion = true;
            t.HoldPickle();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
            t.pickle = true;
            t.HoldTomato();
            Assert.Collection(t.Special, item =>
            {
                Assert.Equal("Hold Tomato", item);
            });
            t.HoldBun();
            t.HoldLettuce();//
            t.HoldOnion();
            t.HoldPickle();
            t.HoldKetchup();
            t.HoldMustard();
            t.HoldMayo();
            string[] specials = new string[] { "Hold Bun", "Hold Lettuce", "Hold Tomato", "Hold Onion", "Hold Pickle", "Hold Ketchup", "Hold Mustard", "Hold Mayo" };
            Assert.Equal(t.Special, specials);
        }
        [Fact]
        public void ShouldHaveEmptySpecialDefault()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.Empty(tb.Special);
        }
        [Fact]
        public void ShouldProvideCorrectDescription()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

    }

}
