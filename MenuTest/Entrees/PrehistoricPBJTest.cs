using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void NotifyOfPropertyChanged()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.PropertyChanged(p, "Special", () =>
             {
                 p.HoldJelly();
                 p.HoldPeanutButter();
             });
        }
        [Fact]
        public void ShouldHaveCorrectSpecials()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            p.HoldJelly();
            Assert.Collection(p.Special, item =>
            {
                Assert.Equal("Hold Jelly", item);
            });
            p.jelly = true;
            p.HoldPeanutButter();
            Assert.Collection(p.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            });
            p.HoldJelly();
            string[] specials = new string[] { "Hold Peanut Butter", "Hold Jelly" };
            Assert.Equal(p.Special, specials);
        }
        [Fact]
        public void ShouldHaveEmptySpecialDefault()
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            Assert.Empty(pb.Special);
        }
        [Fact]
        public void ShouldProvideCorrectDescription()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }
    }

}
