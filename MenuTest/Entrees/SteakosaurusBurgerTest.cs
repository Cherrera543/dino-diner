using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void NotifyofPropertyChanged()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
             {
                 s.HoldBun();
                 s.HoldKetchup();
                 s.HoldMustard();
                 s.HoldPickle();
             });
        }
        [Fact]
        public void ShouldHaveCorrectSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            Assert.Collection(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
            s.bun = true;
            s.HoldKetchup();
            Assert.Collection(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
            s.ketchup = true;
            s.HoldMustard();
            Assert.Collection(s.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
            s.mustard = true;
            s.HoldPickle();
            Assert.Collection(s.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
            s.HoldBun();
            s.HoldKetchup();
            s.HoldMustard();
            string[] specials = new string[] { "Hold Bun", "Hold Pickle", "Hold Ketchup", "Hold Mustard" };
            Assert.Equal(s.Special, specials);

        }
        [Fact]
        public void ShouldHaveEmptySpecialDefault()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);
        }
        [Fact]
        public void ShouldProvideCorrectDescription()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }
    }

}
