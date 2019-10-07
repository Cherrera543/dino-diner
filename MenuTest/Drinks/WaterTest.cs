using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //Correct default price
        [Fact]
        public void CorrectDefaultPrice()
        {
            Water wat = new Water();
            Assert.Equal(.10, wat.Price);
        }
        //Correct default calories
        [Fact]
        public void CorrectDefaultCalories()
        {
            Water wat = new Water();
            Assert.Equal<uint>(0, wat.Calories);
        }
        //Correct default size
        [Fact]
        public void CorrectDefaultSize()
        {
            Water wat = new Water();
            Assert.Equal<Size>(Size.Small, wat.Size);
        }
        //Correct boolean Ice
        [Fact]
        public void CorrectBooleanIce()
        {
            Water wat = new Water();
            Assert.True(wat.Ice);
        }
        //Correct boolean Lemon
        [Fact]
        public void CorrectBooleanLemon()
        {
            Water wat = new Water();
            Assert.False(wat.Lemon);
        }
        //Correct size after setting to small
        [Fact]
        public void CorrectSizeAfterSettingSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            wat.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, wat.Size);
        }
        //Correct price after setting to small
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            wat.Size = Size.Small;
            Assert.Equal(.10, wat.Price);
        }
        //Correct calories after setting to small
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            wat.Size = Size.Small;
            Assert.Equal<uint>(0, wat.Calories);
        }
        //Correct size after setting to medium
        [Fact]
        public void CorrectSizeAfterSettingMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, wat.Size);
        }
        //Correct price after setting to medium
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal(.10, wat.Price);
        }
        //Correct calories after setting to medium
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<uint>(0, wat.Calories);
        }
        //Correct size after setting to large
        [Fact]
        public void CorrectSizeAfterSettingLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, wat.Size);
        }
        //Correct price after setting to large
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal(.10, wat.Price);
        }
        //Correct calories after setting to large
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<uint>(0, wat.Calories);
        }
        //Correct Ice boolean after HoldIce()
        [Fact]
        public void CorrectIceAFterHoldIce()
        {
            Water wat = new Water();
            wat.HoldIce();
            Assert.False(wat.Ice);
        }
        //Correct Lemon boolean after AddLemon()
        [Fact]
        public void CorrectLemonAfterAddLemon()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.True(wat.Lemon);
        }
        //Correct Ingredients
        [Fact]
        public void CorrectIngredients()
        {
            Water wat = new Water();
            List<string> ingredients = wat.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Equal<int>(1, ingredients.Count);
        }
    }
}
