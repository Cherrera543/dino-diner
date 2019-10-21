using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void NotifyofPropertyChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldBun();
                b.HoldPeppers();
                b.HoldOnion();
            });

        }
        [Fact]
        public void ShouldHaveCorrectSpecials()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            Assert.Collection(b.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
            b.bun = true;
            b.HoldOnion();
            Assert.Collection(b.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
            b.onions = true;
            b.HoldPeppers();
            Assert.Collection(b.Special, item =>
            {
                Assert.Equal("Hold Pepper", item);
            });
            b.HoldBun();
            b.HoldOnion();
            string[] specials = new string[] { "Hold Bun", "Hold Pepper", "Hold Onion" };
            Assert.Equal(b.Special, specials);
        }
        [Fact]
        public void ShouldHaveEmptySpecialDefault()
        {
            Brontowurst b = new Brontowurst();
            Assert.Empty(b.Special);
        }
        [Fact]
        public void ShouldProvideCorrectDescription()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }
    }

}
