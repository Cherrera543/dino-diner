using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //Correct default size
        [Fact]
        public void CorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        //Correct default calories
        [Fact]
        public void CorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        //Correct default price
        [Fact]
        public void CorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal(.59, java.Price);
        }
        //Correct default Ice boolean
        [Fact]
        public void CorrectDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }
        //Correct defaul SpaceForCream boolean
        [Fact]
        public void CorrectDefaultRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }
        //Correct size after setting to small
        [Fact]
        public void CorrectSizeAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        //Correct price after setting to small
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal(.59, java.Price);
        }
        //Correct calories after setting to small
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        //Correct size after setting to medium
        [Fact]
        public void CorrectSizeAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, java.Size);
        }
        //Correct price after setting to medium
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal(.99, java.Price);
        }
        //Correct calories after setting to medium
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        //Correct size after setting to large
        [Fact]
        public void CorrectSizeAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<Size>(Size.Medium, java.Size);
        }
        //Correct price after setting to large
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price);
        }
        //Correct calories after setting to large
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        //Correct Ice boolean after AddIce()
        [Fact]
        public void CorrectIceAfterAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        //Correct Cream boolean after LeaveSpaceForCream()
        [Fact]
        public void CorrectRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        //Correct Ingredients
        [Fact]
        public void CorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
