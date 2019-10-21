using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void NotifyofPropertyChange()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", () =>
             {
                 v.HoldCheese();
                 v.HoldDressing();
                 v.HoldLettuce();
             });
        }
        [Fact]
        public void ShouldHaveCorrectSpecials()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            Assert.Collection(v.Special, item =>
            {
                Assert.Equal("Hold Cheese", item);
            });
            v.cheese = true;
            v.HoldDressing();
            Assert.Collection(v.Special, item =>
            {
                Assert.Equal("Hold Dressing", item);
            });
            v.dressing = true;
            v.HoldLettuce();
            Assert.Collection(v.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
            v.HoldCheese();
            v.HoldDressing();
            string[] specials = new string[] { "Hold Dressing", "Hold Lettuce", "Hold Cheese" };
            Assert.Equal(v.Special, specials);
        }
        [Fact]
        public void ShouldHaveEmptySpecialDefault()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);
        }
        [Fact]
        public void ShouldProvideCorrectDescription()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }
    }
}
