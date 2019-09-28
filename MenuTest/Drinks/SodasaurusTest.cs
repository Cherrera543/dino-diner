using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
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

        //correct caloris after setting small
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
    }
}
