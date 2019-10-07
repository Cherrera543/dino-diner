using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //Set each flavor possible
        [Fact]
        public void SetEachFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Grape;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Grape, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }
        //The correct default calories
        [Fact]
        public void hasCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        //The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.5, soda.Price);
        }
        //The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }
        //The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(Size.Small, soda.Size);
        }

        //Correct Size After setting to Small
        [Fact]
        public void ShouldHaveCorrectSizeAfterSettingToSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal(Size.Small, soda.Size);
        }
        //correct calories after setting small
        [Fact]
        public void ShouldhaveCorrectCaloriesAfterSettingToSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }
        //correct price after setting small
        [Fact]
        public void ShouldhaveCorrectPriceAfterSettingToSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal(1.50, soda.Price);
        }
        //Correct Size After setting to Medium
        [Fact]
        public void ShouldHaveCorrectSizeAfterSettingToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(Size.Medium, soda.Size);
        }
        //correct caloris after setting medium
        [Fact]
        public void ShouldhaveCorrectCaloriesAfterSettingToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }
        //correct price after setting medium
        [Fact]
        public void ShouldhaveCorrectPriceAfterSettingToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price);
        }
        //Correct Size After setting to Large
        [Fact]
        public void ShouldHaveCorrectSizeAfterSettingToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(Size.Large, soda.Size);
        }
        //correct calories after setting large
        [Fact]
        public void ShouldhaveCorrectCaloriesAfterSettingToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }
        //correct price after setting large
        [Fact]
        public void ShouldhaveCorrectPriceAfterSettingToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price);
        }

        //HoldIce() property check
        [Fact]
        public void ShouldChangeIceToFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        //correct ingredients are in the list
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

    }
}
